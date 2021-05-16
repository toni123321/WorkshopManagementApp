using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class Student: Person
    {
        public Student(string fname, string lname, string pcn, string email, string role) : base(fname, lname, pcn, email, role)
        {
            
        }

        public override string ToString()
        {
            return $"Student: {base.ToString()}";
        }
    }
}
