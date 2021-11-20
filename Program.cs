using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jan", "Kowalski", 1998);
            Employee employee = new Employee("Adam", "Nowak", 1999, 5000);
            Person person2 = new Employee("Joanna", "Kowalska", 1981, 6600);
            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);

            foreach (Person p in people)
            {
                if (p.GetType() == typeof(Person))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                } 
                else if (p.GetType() == typeof(Employee))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Employee e = (Employee)p;
                    Console.WriteLine($"Salary = {e.Salary}");
                }
                else
                {
                    Console.WriteLine("No idea");
                }
            }

        }
    }
}
