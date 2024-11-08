using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day2_Inkapsulation
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName => $"{FirstName} {LastName}";

        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
