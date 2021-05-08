using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Teacher: Person
    {
        

        public Teacher(string fname, string lname, string pcn, string email, string role) : base(fname, lname, pcn, email, role)
        {
        }

        public override string ToString()
        {
            return $"Teacher: {base.ToString()}";
        }
    }
}
