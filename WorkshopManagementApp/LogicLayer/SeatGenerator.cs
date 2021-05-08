using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace LogicLayer
{
    public class SeatGenerator
    {
        private List<WorkshopPerson> workshopPeople;

        public SeatGenerator(List<WorkshopPerson> workshopPeople)
        {
            this.workshopPeople = workshopPeople;
        }

        private List<int> GetSeatNrList(Workshop w)
        {
            List<int> seatNrs = new List<int>(); 
            foreach (WorkshopPerson wp in workshopPeople)
            {
                if (wp.Workshop.Id == w.Id)
                {
                    seatNrs.Add(((OnsiteWorkshopPerson)(wp)).SeatNr);
                }
            }

            return seatNrs;
        }

        public int GenerateSeat(Workshop w)
        {
            Random rand = new Random();
            int seatNr = rand.Next(1, w.Capacity + 1);
            while (GetSeatNrList(w).Contains(seatNr))
            {
                rand = new Random();
                seatNr = rand.Next(1, w.Capacity + 1);
            }
            return seatNr;
        }

    }
}
