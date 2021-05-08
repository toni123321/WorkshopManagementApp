using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
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
            set { this.fname = value; }
        }

        public string Lname
        {
            get { return this.lname; }
            set { this.lname = value; }
        }
        public string Pcn
        {
            get { return this.pcn; }
            set { this.pcn = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        protected Person(string fname, string lname, string pcn, string email, string role)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Pcn = pcn;
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
