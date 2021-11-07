using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(Factorial(x));
            }
            else
            {
                Console.WriteLine("Liczba nie może być mniejsza od 0!");
            }
            
            
        }

        static int Factorial(int x)
        {

                if (x == 0)
                {
                    return 1;

                }

                int result = x * Factorial(x - 1);
                return result;
            }
    }
}
