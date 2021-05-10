using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CustomExceptions;

namespace Models
{
    public class OnsiteWorkshop: Workshop
    {
        private string address;
        private string roomNumber;

        public string Address
        {
            get { return this.address; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^([A-Z][a-z]+([,]\s?[A-Z][a-z]+)?\s)?\d{1,4}[A-Z]?\s(\d{1,3}(st|nd|rd|th))?[\w]+(\s[A-Z][a-z]{1,3}\.)?$");
                if (isValid)
                {
                    this.address = value;
                }
                else
                {
                    throw new InputFieldException("Address is not in the correct format!");
                }
            }
        }

        public string RoomNumber
        {
            get { return this.roomNumber; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[0-9]{1,4}[A-Za-z]?$");
                if (isValid)
                {
                    this.roomNumber = value;
                }
                else
                {
                    throw new InputFieldException("Room number can contain up to 4 digits(Range: 1 - 9999) and one letter(capital or small)");
                }
                
            }
        }

        public OnsiteWorkshop(string title, string shortDescription, int capacity, string address, string roomNumber)
            : base(title, shortDescription, capacity)
        {
            this.Address = address;
            this.RoomNumber = roomNumber;
        }

        public OnsiteWorkshop(int id, string title, string shortDescription, int capacity, int nrOfParticipants, bool isAvailable, bool isStarted, Person teacher, string address, string roomNumber) 
            : base(id, title, shortDescription, capacity, nrOfParticipants, isAvailable, isStarted, teacher)
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
