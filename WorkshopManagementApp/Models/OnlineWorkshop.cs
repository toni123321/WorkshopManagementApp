using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CustomExceptions;

namespace Models
{
    public class OnlineWorkshop: Workshop
    {
        private string url;


        public string Url
        {
            get { return this.url; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^(https?:\/\/)?([\w\-])+\.{1}([a-zA-Z]{2,63})[\/\w-]*\/?\??([^#\n\r]*)?#?([^\n\r]*)$");
                if (isValid)
                {
                    this.url = value;
                }
                else
                {
                    throw new InputFieldException("URL is not in the correct format!");
                }
                
            }
        }

        public OnlineWorkshop(string title, string shortDescription, int capacity, string url)
            : base(title, shortDescription, capacity)
        {
            this.Url = url;
        }

        public OnlineWorkshop(int id, string title, string shortDescription, int capacity, int nrOfParticipants, bool isAvailable, bool isStarted, Person teacher, string url) 
            : base(id, title, shortDescription, capacity, nrOfParticipants, isAvailable, isStarted, teacher)
        {
            this.Url = url;
        }

        

        public override string ToString()
        {
            return $"Online:{base.ToString()}";
        }
    }
}
