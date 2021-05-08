using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OnsiteWorkshop: Workshop
    {
        private string address;
        private string roomNumber;

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string RoomNumber
        {
            get { return this.roomNumber; }
            set { this.roomNumber = value; }
        }

        public OnsiteWorkshop(int id, string title, string shortDescription, int capacity, int nrOfParticipants, bool isAvailable, bool isStarted, Person teacher, string address, string roomNumber) 
            : base(id, title, shortDescription, capacity, nrOfParticipants, isAvailable, isStarted, teacher)
        {
            this.Address = address;
            this.RoomNumber = roomNumber;
        }

        public OnsiteWorkshop(int id, string title, string shortDescription, int capacity, string address, string roomNumber)
            : base(id, title, shortDescription, capacity)
        {
            this.Address = address;
            this.RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"Onsite:{base.ToString()}";
        }
    }
}
