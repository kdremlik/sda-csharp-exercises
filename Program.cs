using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj znak");
            char sign = Convert.ToChar(Console.ReadLine());



            PrintTriangle(height, sign);
        }

        private static void PrintTriangle(int height, char sign)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }

            for (int i = height - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}

