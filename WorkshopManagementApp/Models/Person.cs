using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CustomExceptions;

namespace Models
{
    [Serializable]
    public abstract class Person
    {
        private string fname;
        private string lname;
        private string pcn;
        private string email;
        private string role;

        public string Fname
        {
            get { return this.fname; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+([ -][A-Z]{1}[a-z]+){0,}$");
                if (isValid)
                {
                    this.fname = value;
                }
                else
                {
                    throw new InputFieldException("First name is not in the correct format!");
                }
                
            }
        }

        public string Lname
        {
            get { return this.lname; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+([ -][A-Z]{1}[a-z]+){0,}$");
                if (isValid)
                {
                    this.lname = value;
                }
                else
                {
                    throw new InputFieldException("Last name is not in the correct format!");
                }
                
            }
        }
        public string Pcn
        {
            get { return this.pcn; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[0-9]{6}$");
                if (isValid)
                {
                    this.pcn = value;
                }
                else
                {
                    throw new InputFieldException("PCN is not in the correct format!");
                }
                
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Za-z0-9]+[^A-Za-z0-9@]?[A-Za-z0-9]*@[A-z-]+[.][a-z]+$");
                if (isValid)
                {
                    this.email = value;
                }
                else
                {
                    throw new InputFieldException("Email is not in the correct format!");
                }
            }
        }

        public string Role
        {
            get { return this.role; }
            set
            {
                if (value == "Student" || value == "Teacher")
                {
                    this.role = value;
                }
                else
                {
                    throw new InputFieldException($"Role can be only Student or Teacher!");
                }
            }
        }

        protected Person(string fname, string lname, string pcn, string email, string role)
        {
            this.Pcn = pcn;
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
            this.Role = role;
        }

        public override string ToString()
        {
            return $"PCN:{this.Pcn}; First name: {this.Fname}; Last name: {this.Lname}; " +
                   $"Email: {this.Email}";
        }
    }
}
