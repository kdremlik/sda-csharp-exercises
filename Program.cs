using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Mruczek");
            cat1.MakeSound();
            Dog dog1 = new Dog("Azor");
            dog1.MakeSound();

            List<Animal> animals = new List<Animal>();
            animals.Add(dog1);
            animals.Add(cat1);

            foreach (Animal a in animals)
            {
                a.MakeSound();
                if (a is Cat)
                {
                    Console.WriteLine("Cat");
                }
                else if (a is Dog)
                {
                    Console.WriteLine("Dog");
                }
                else
                {
                    Console.WriteLine("Unknown");
                }
            }

        }
    }
}
