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
        public OnlineWorkshopPerson(Workshop workshop, Person person, string loginCode) : base(workshop, person)
        {
            this.LoginCode = loginCode;
        }

        public override string ToString()
        {
            return $"Online: {base.ToString()} Login code: {LoginCode}";
        }
    }
}
