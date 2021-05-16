using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class WorkshopPerson
    {
        public string Id
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

        protected WorkshopPerson(Workshop workshop, Person person)
        {
            this.Id = $"{workshop.Id}-{person.Pcn}";
            this.Workshop = workshop;
            this.Person = person;
        }


        public override string ToString()
        {
            return $"Workshop: {Workshop.Title};";
        }

    }
}
