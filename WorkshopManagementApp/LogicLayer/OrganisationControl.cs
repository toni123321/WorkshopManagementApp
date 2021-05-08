using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace LogicLayer
{
    public class OrganisationControl
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value;  }
        }

        public WorkshopManager WorkshopManager
        {
            get;
            set;
        }

        public PersonManager PersonManager
        {
            get;
            set;
        }

        public WorkshopPersonManager WorkshopPersonManager
        {
            get;
            set;
        }

        public OrganisationControl(string name)
        {
            this.Name = name;
            this.PersonManager = new PersonManager();
            this.WorkshopManager = new WorkshopManager();
            this.WorkshopPersonManager = new WorkshopPersonManager();
        }

        
    }
}
