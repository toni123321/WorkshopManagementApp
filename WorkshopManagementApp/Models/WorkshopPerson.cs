using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class WorkshopPerson
    {
        public int Id
        {
            get;
            set;
        }

        public Workshop Workshop
        {
            get;
            set;
        }

        public Person Person
        {
            get;
            set;
        }

        protected WorkshopPerson(int id, Workshop workshop, Person person)
        {
            this.Id = id;
            this.Workshop = workshop;
            this.Person = person;
        }
        


    }
}
