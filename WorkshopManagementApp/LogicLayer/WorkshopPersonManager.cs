using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Models;

namespace LogicLayer
{
    public class WorkshopPersonManager
    {
        
        private IStorage storage;
        private WorkshopManager workshopManager = new WorkshopManager();


        public List<WorkshopPerson> WorkshopPeople
        {
            get;
            set;
        }

        public WorkshopPersonManager()
        {
            this.WorkshopPeople = new List<WorkshopPerson>();
            this.storage = new WorkshopPersonDbManager("Server=localhost;Uid=root;Database=workshop_management;Pwd=");
            LoadDataFromStorage();
        }

        public void LoadDataFromStorage()
        {
            WorkshopPeople = storage.ReadAll() as List<WorkshopPerson>;
        }

        public bool AssignTeacherToWorkshop(Workshop w, Person p)
        {
            bool isAssignPossible = GetPersonAssignToWorkshop(w, p) == null &&
                                    p is Teacher && w.Teacher == null;
            if (isAssignPossible)
            {
                WorkshopPerson currWorkshopPerson;
                if (w is OnsiteWorkshop)
                {
                    currWorkshopPerson = new OnsiteWorkshopPerson(w, p);
                }
                else
                {
                    LoginCodeGenerator loginCodeGenerator = new LoginCodeGenerator(this.WorkshopPeople);
                    currWorkshopPerson = new OnlineWorkshopPerson(w, p,
                        loginCodeGenerator.GenerateCode(w));
                }

                storage.Create(currWorkshopPerson);
                LoadDataFromStorage();
                w.Teacher = p; // assign teacher to the workshop
                workshopManager.UpdateWorkshop(w);
                return true;
            }
            return false;
        }

        public bool AssignParticipantToWorkshop(Workshop w, Person p)
        {
            bool isThereFreeSpot = GetNrOfParticipantsPerWorkshop(w) < w.Capacity;
            bool isAssignPossible = GetPersonAssignToWorkshop(w, p) == null &&
                                    isThereFreeSpot;
            if (isAssignPossible)
            {
                WorkshopPerson currWorkshopPerson;
                if (w is OnsiteWorkshop)
                {
                    SeatGenerator seatGenerator = new SeatGenerator(this.WorkshopPeople);

                    currWorkshopPerson = new OnsiteWorkshopPerson(w, p,
                            seatGenerator.GenerateSeat(w));
                    
                }
                else
                {
                    LoginCodeGenerator loginCodeGenerator = new LoginCodeGenerator(this.WorkshopPeople);
                    currWorkshopPerson = new OnlineWorkshopPerson(w, p, 
                        loginCodeGenerator.GenerateCode(w));
                }
                
                storage.Create(currWorkshopPerson);
                LoadDataFromStorage();
                
                w.NrOfParticipants = GetNrOfParticipantsPerWorkshop(w);
                w.CheckCapacity();

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
            foreach (WorkshopPerson wp in this.WorkshopPeople)
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
            foreach (WorkshopPerson wp in this.WorkshopPeople)
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

        public List<WorkshopPerson> GetPersonEnrollments(Person p)
        {
            List<WorkshopPerson> enrollments = new List<WorkshopPerson>();
            foreach (WorkshopPerson wp in this.WorkshopPeople)
            {
                if (wp.Person.Pcn == p.Pcn)
                {
                    enrollments.Add(wp);
                }
            }

            return enrollments;
        }

        public WorkshopPerson GetWorkshopPerson(Workshop w, Person p)
        {
            foreach (WorkshopPerson wp in this.WorkshopPeople)
            {
                if(wp.Workshop.Id == w.Id && wp.Person.Pcn == p.Pcn)
                {
                    return wp;
                }
            }

            return null;
        }


        public bool RemovePersonAssignToWorkshop(Workshop w, Person p)
        {
            if(GetWorkshopPerson(w, p) != null)
            {
                WorkshopPerson currWorkshopPerson = GetWorkshopPerson(w, p);
                storage.Delete(currWorkshopPerson.Id);
                LoadDataFromStorage();
                //this.workshopPeople.Remove(currWorkshopPerson);
                if (w.Teacher != null && w.Teacher.Pcn == p.Pcn)
                {
                    w.Teacher = null;
                }
                else
                {
                    w.NrOfParticipants = GetNrOfParticipantsPerWorkshop(w);
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
