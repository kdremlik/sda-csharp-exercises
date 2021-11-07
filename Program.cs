using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string surname = "Doe";
            string secondName = "";

            string street = "Derrick Street";
            string streetNumber = "213";
            string flat = "1c";
            string city = "Boston";
            int age = 24;

            PrintText("Klaudia", "Nowak", true, 24, "Derrick Street", 3, 63, "Wrocław");



        }

        private static void PrintText(string name, string secondName, string isFemale, int age, string street,
            int streetNumber, int flat, string city)
        {

        }

        private static bool IsWoman(string name)
        {
            if (name.EndsWith("a"))
            {

                return true;
            }
        }

        private static string Salutation(int age, string name)
        {
            if (age >= 18 && IsWoman(name))
            {
                string adultWoman = "Szanowna Pani";
                return adultWoman;
            }
            
        }

        //private static string IsSecondName(string secondName)
        //{
        //    if (secondName != "")
        //    {
        //        return secondName;
        //    }
        //    else
        //    {

        //    }
        //}
    }
}
