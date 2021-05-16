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
        public OnsiteWorkshopPerson(Workshop workshop, Person person, int seatNr) : base(workshop, person)
        {
            this.SeatNr = seatNr;
        }
        public OnsiteWorkshopPerson(Workshop workshop, Person person) : base(workshop, person)
        {
            this.SeatNr = 0;
        }

        public override string ToString()
        {
            return $"Onsite: {base.ToString()} Seat number: {SeatNr}";
        }
    }
}
