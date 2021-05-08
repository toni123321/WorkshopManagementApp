using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Workshop
    {
        public delegate void CapacityHandle(string message);

        public event CapacityHandle ExceedAlmostFullCapacity;

        private string title;
        private string shortDescription;
        private int capacity;
        private int nrOfParticipants;

        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get { return this.title;}
            set { this.title = value; }
        }

        public string ShortDescription
        {
            get { return this.shortDescription; }
            set { this.shortDescription = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public Person Teacher
        {
            get;
            set;
        }

        public int NrOfParticipants
        {
            get { return this.nrOfParticipants; }
            set
            {
                //TODO: (0.9 * this.Capacity)
                if (value >= 1)
                {
                    NotifyNewWorkshopCapacityWarning($"The nr of participants({value}) exceeds 90% of workshop capacity!");
                }
                this.nrOfParticipants = value;
            }
        }

        public bool IsAvailable
        {
            get;
            set;
        }

        public bool IsStarted
        {
            get;
            set;
        }

        protected Workshop(int id, string title, string shortDescription, int capacity, 
            int nrOfParticipants, bool isAvailable, bool isStarted, Person teacher)
        {
            this.Id = id;
            this.Title = title;
            this.ShortDescription = shortDescription;
            this.Capacity = capacity;

            this.NrOfParticipants = nrOfParticipants;
            this.IsAvailable = isAvailable;
            this.IsStarted = isStarted;
            this.Teacher = teacher;
        }

        protected Workshop(int id, string title, string shortDescription, int capacity)
        {
            this.Id = id;
            this.Title = title;
            this.ShortDescription = shortDescription;
            this.Capacity = capacity;

            this.NrOfParticipants = 0;
            this.IsAvailable = true;
            this.IsStarted = false;
        }

        public override string ToString()
        {
            return $"Title:{this.Title}; Capacity: {this.Capacity}";
        }


        public void NotifyNewWorkshopCapacityWarning(string message)
        {
            CapacityHandle handle;
            handle = this.ExceedAlmostFullCapacity;

            if (handle != null)
            {
                handle(message);
        
            }
        }
    }
}
