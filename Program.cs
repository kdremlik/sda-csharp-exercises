using System;

namespace sda_csharp_exercises
{
    class Program
    {
		public static void ArithmeticSequence(int[] sequ)
        {
            Console.WriteLine("Ciąg: ");
            int printValue = sequ[1];
            Console.Write(printValue);
            for (int i = 1; i < sequ[0]; i++)
            {
                printValue += sequ[2];
                Console.Write($", {printValue}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Długość ciągu: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pierwsza wartość: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Różnica: ");
            int difference = Convert.ToInt32(Console.ReadLine());

            int[] sequ = { lenght, firstValue, difference };
            ArithmeticSequence(sequ);
        }
	}
}
