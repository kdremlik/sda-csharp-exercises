using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jan", " Kowalski", 1998, 3200);
            Person person = new Employee("Adam", "Nowak", 1981, 5000);
            //Console.WriteLine(person.Salary);
            Employee employee2 = (Employee) person;
            Console.WriteLine(employee2.Salary);
        }
    }
}
