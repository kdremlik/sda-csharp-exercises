using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _yearOfBirth;
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public Person() : this("", "", 1900)
        {
            
        }
        public void WhoAmI()
        {
            Console.WriteLine($"My name is {LastName}. {FirstName} {LastName}");
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;
    }
}
