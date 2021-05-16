using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CustomExceptions;

namespace Models
{
    [Serializable]
    public abstract class Workshop
    {
        public delegate void CapacityHandle(string message);

        public event CapacityHandle ExceedAlmostFullCapacity;

        private string id;
        private string title;
        private string shortDescription;
        private int capacity;
        private int nrOfParticipants;

        public string Id
        {
            get { return this.id; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[0-9]{6}$");
                if (isValid)
                {
                    this.id = value;
                }
                else
                {
                    throw new InputFieldException("Id is not in the correct format!");
                }
            }
        }

        public string Title
        {
            get { return this.title;}
            set
            {
                bool isValid = Regex.IsMatch(value, @"^([A-Za-z0-9.&]+[ ]?){1,}[^\s]$");
                if (isValid)
                {
                    this.title = value;
                }
                else
                {
                    throw new InputFieldException("Title is not in the correct format!");
                }
                
            }
        }

        public string ShortDescription
        {
            get { return this.shortDescription; }
            set
            {
                if (value.Length <= 200)
                {
                    this.shortDescription = value;
                }
                else
                {
                    throw new InputFieldException("The description is too long!");
                }
            }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                bool isValid = Regex.IsMatch(value.ToString(), @"^[1-9]{1}[0-9]*$");
                if (isValid)
                {
                    this.capacity = value;
                }
                else
                {
                    throw new InputFieldException("Capacity should contain only digits higher than 0!");
                }
                
            }
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
                /*if (value >= (0.9 * this.Capacity))
                {
                    NotifyNewWorkshopCapacityWarning($"The nr of participants({value}) exceeds 90% of workshop capacity!");
                }*/
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


        /// <summary>
        /// Used this to:
        /// 1) assign from the local environment to Storage
        /// 2) To test app
        /// </summary>
        protected Workshop(string title, string shortDescription, int capacity)
        {
            this.Id = "000000";
            this.Title = title;
            this.ShortDescription = shortDescription;
            this.Capacity = capacity;

            this.NrOfParticipants = 0;
            this.IsAvailable = true;
            this.IsStarted = false;
            this.Teacher = null;
        }

        /// <summary>
        /// Used only from the Storage: for example DB
        /// </summary>
        protected Workshop(string id, string title, string shortDescription, int capacity, 
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

        public void CheckCapacity()
        {
            if (this.NrOfParticipants >= (0.9 * this.Capacity))
            {
                NotifyNewWorkshopCapacityWarning($"The nr of participants({this.NrOfParticipants}) exceeds 90% of workshop capacity!");
            }
        }

    }
}

