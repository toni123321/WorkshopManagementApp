using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OnlineWorkshopPerson: WorkshopPerson
    {
        public string LoginCode
        {
            get;
            set;
        }
        public OnlineWorkshopPerson(int id, Workshop workshop, Person person, string loginCode) : base(id, workshop, person)
        {
            this.LoginCode = loginCode;
        }
    }
}
