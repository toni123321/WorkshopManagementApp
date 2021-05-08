using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OnsiteWorkshopPerson: WorkshopPerson
    {
        public int SeatNr
        {
            get;
            set;
        }
        public OnsiteWorkshopPerson(int id, Workshop workshop, Person person, int seatNr) : base(id, workshop, person)
        {
            this.SeatNr = seatNr;
        }
        public OnsiteWorkshopPerson(int id, Workshop workshop, Person person) : base(id, workshop, person)
        {
            this.SeatNr = 0;
        }
    }
}
