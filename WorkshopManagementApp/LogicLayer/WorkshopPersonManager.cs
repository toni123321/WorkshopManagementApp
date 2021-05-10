using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Models;

namespace LogicLayer
{
    public class WorkshopPersonManager
    {
        private List<WorkshopPerson> workshopPeople;
        private IStorage storage;
        private WorkshopManager workshopManager = new WorkshopManager();


        public WorkshopPersonManager()
        {
            this.workshopPeople = new List<WorkshopPerson>();
            this.storage = new WorkshopPersonDbManager("Server=localhost;Uid=root;Database=workshop_management;Pwd=");
            LoadDataFromStorage();
        }

        public void LoadDataFromStorage()
        {
            workshopPeople = storage.ReadAll() as List<WorkshopPerson>;
        }

        public bool AssignPersonToWorkshop(int id, Workshop w, Person p)
        {
            
            bool isThereFreeSpot = (GetNrOfParticipantsPerWorkshop(w) < w.Capacity) ||
                                   (GetNrOfParticipantsPerWorkshop(w) == w.Capacity &&
                                    p is Teacher && w.Teacher == null);

            bool isAssignPossible = GetPersonAssignToWorkshop(w, p) == null &&
                                    isThereFreeSpot;
            if (isAssignPossible)
            {
                WorkshopPerson currWorkshopPerson;
                if (w is OnsiteWorkshop)
                {
                    SeatGenerator seatGenerator = new SeatGenerator(this.workshopPeople);

                    if (p is Teacher)
                    {
                        currWorkshopPerson = new OnsiteWorkshopPerson(id, w, p);
                    }
                    else
                    {
                        currWorkshopPerson = new OnsiteWorkshopPerson(id, w, p,
                            seatGenerator.GenerateSeat(w));
                    }
                }
                else
                {
                    LoginCodeGenerator loginCodeGenerator = new LoginCodeGenerator(this.workshopPeople);
                    currWorkshopPerson = new OnlineWorkshopPerson(id, w, p, 
                        loginCodeGenerator.GenerateCode(w));
                }
                
                storage.Create(currWorkshopPerson);
                LoadDataFromStorage();

                //workshopPeople.Add(currWorkshopPerson);
                
                if (p is Teacher)
                {
                    w.Teacher = p;
                }
                else
                {
                    w.NrOfParticipants = GetNrOfParticipantsPerWorkshop(w);
                    w.CheckCapacity();
                }
                //TODO: Update here workshop
                workshopManager.UpdateWorkshop(w);

                return true;
            }

            return false;
        }


        private Person GetPersonAssignToWorkshop(Workshop w, Person p)
        {
            foreach (Person person in GetPeopleAssignToWorkshop(w))
            {
                if(person.Pcn == p.Pcn)
                {
                    return person;
                }
            }

            return null;
        }

        public List<Person> GetPeopleAssignToWorkshop(Workshop w)
        {
            List<Person> people = new List<Person>();
            foreach (WorkshopPerson wp in this.workshopPeople)
            {
                if (wp.Workshop.Id == w.Id)
                {
                    people.Add(wp.Person);
                }
            }

            return people;
        }

        public List<Person> GetOnlyParticipants(Workshop w)
        {
            List<Person> people = new List<Person>();
            foreach (WorkshopPerson wp in this.workshopPeople)
            {
                if (wp.Workshop.Id == w.Id)
                {
                    if (w.Teacher != null && w.Teacher.Pcn == wp.Person.Pcn)
                    {
                        continue;
                    }
                    people.Add(wp.Person);
                }
            }

            return people;
        }

        public List<Workshop> GetWorkshopsPersonAssignTo(Person p)
        {
            List<Workshop> workshops = new List<Workshop>();
            foreach (WorkshopPerson wp in this.workshopPeople)
            {
                if (wp.Person.Pcn == p.Pcn)
                {
                    workshops.Add(wp.Workshop);
                }
            }

            return workshops;
        }

        public WorkshopPerson GetWorkshopPerson(Workshop w, Person p)
        {
            foreach (WorkshopPerson wp in this.workshopPeople)
            {
                if(wp.Workshop.Id == w.Id && wp.Person.Pcn == p.Pcn)
                {
                    return wp;
                }
            }

            return null;
        }


        public bool RemoveWorkshopParticipant(Workshop w, Person p)
        {
            if(GetWorkshopPerson(w, p) != null)
            {
                WorkshopPerson currWorkshopPerson = GetWorkshopPerson(w, p);
                storage.Delete(currWorkshopPerson.Id);
                LoadDataFromStorage();
                //this.workshopPeople.Remove(currWorkshopPerson);
                if (p is Student)
                {
                    w.NrOfParticipants = GetNrOfParticipantsPerWorkshop(w);
                }
                else
                {
                    w.Teacher = null;
                }
                // TODO: Update workshop here
                workshopManager.UpdateWorkshop(w);

                return true;
            }

            return false;
        }
        
        public int GetNrOfParticipantsPerWorkshop(Workshop w)
        {
            if (w.Teacher == null)
            {
                return GetPeopleAssignToWorkshop(w).Count;
            }
            else
            {
                //Teacher is not count as participant
                return GetPeopleAssignToWorkshop(w).Count - 1;
            }
        }
    }
}
