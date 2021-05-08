using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OnlineWorkshop: Workshop
    {
        private string url;


        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }

        public OnlineWorkshop(int id, string title, string shortDescription, int capacity, int nrOfParticipants, bool isAvailable, bool isStarted, Person teacher, string url) 
            : base(id, title, shortDescription, capacity, nrOfParticipants, isAvailable, isStarted, teacher)
        {
            this.Url = url;
        }

        public OnlineWorkshop(int id, string title, string shortDescription, int capacity, string url)
            : base(id, title, shortDescription, capacity)
        {
            this.Url = url;
        }

        public override string ToString()
        {
            return $"Online:{base.ToString()}";
        }
    }
}
