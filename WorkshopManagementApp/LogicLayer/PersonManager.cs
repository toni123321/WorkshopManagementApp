using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Models;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace LogicLayer
{
    public class PersonManager
    {
        private List<Person> people;
        private IStorage storage;

        public PersonManager()
        {
            this.people = new List<Person>();
            this.storage = new PersonDbManager("Server=localhost;Uid=root;Database=workshop_management;Pwd=");
            LoadDataFromStorage();
        }


        public void LoadDataFromStorage()
        {
            people = storage.ReadAll() as List<Person>;
        }
        

        public bool AddPerson(Person person)
        {
            if (GetPerson(person.Pcn) != null)
            {
                return false;
            }
            storage.Create(person);
            LoadDataFromStorage();
            //people.Add(person);
            return true;
            
        }

        public bool RemovePerson(string pcn)
        {
            if (GetPerson(pcn) != null)
            {
                /*Person currPerson = GetPerson(pcn);
                people.Remove(currPerson);*/
                storage.Delete(pcn);
                LoadDataFromStorage();
                return true;
            }

            return false;
        }

        public bool UpdatePerson(Person person)
        {
            //Person currPerson;
            if(GetPerson(person.Pcn) != null)
            {
                /*currPerson = GetPerson(person.Pcn);
                int index = people.IndexOf(currPerson);
                people.Remove(currPerson);
                people.Insert(index, person);*/
                storage.Update(person);
                LoadDataFromStorage();
                return true;
            }

            return false;
        }

        public Person GetPerson(string pcn)
        {
            foreach (Person p in people)
            {
                if (p.Pcn == pcn)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Person> GetAllPeople()
        {
            return people;
        }

        private List<Person> GetSpecificPeople(string filter)
        {
            List<Person> specificPeople = new List<Person>();
            foreach (Person p in this.people)
            {
                if ((filter == "teachers" && p is Teacher) ||
                    (filter == "students" && p is Student))
                {
                    specificPeople.Add(p);
                }
            }

            return specificPeople;
        }

        public List<Person> GetTeachers()
        {
            return GetSpecificPeople("teachers");
        }

        public List<Person> GetStudents()
        {
            return GetSpecificPeople("students");
        }

    }
}
