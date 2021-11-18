using System;

namespace sda_csharp_exercises
{
    class PersonalInfo
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public bool IsFemale { get; set; }
        public int Age { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int Flat { get; set; }
        public string City { get; set; }
        public string Surname { get; set; }

        public PersonalInfo(string name, string secondName, string surname, bool isFemale, int age, string street,
            int streetNumber, int flat, string city)
        {
            Name = name;
            SecondName = secondName;
            Surname = surname;
            IsFemale = isFemale;
            Age = age;
            Street = street;
            StreetNumber = streetNumber;
            Flat = flat;
            City = city;
        }

        //public PersonalInfo(string name,string surname, bool isFemale, int age, string street,
        //    int streetNumber, int flat, string city)
        //{
            
        //    Name = name;
        //    Surname = surname;
        //    IsFemale = isFemale;
        //    Age = age;
        //    Street = street;
        //    StreetNumber = streetNumber;
        //    Flat = flat;
        //    City = city;
        //}


    }
    class Program
    {
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj imię:");
            //string name = Console.ReadLine();
            string name = "Kobiet";
            
            //Console.WriteLine("Podaj drugie imię :");
            //string secondName = Console.ReadLine();
            string secondName = "Drugiemie";
            
            //Console.WriteLine("Podaj nazwisko:");
            //string surname = Console.ReadLine();
            string surname = "Nazwisko";

            bool isFemale = IsWoman(name);

            //Console.WriteLine("Podaj wiek:");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = 12;

            //Console.WriteLine("Ulica:");
            //string street = Console.ReadLine();
            string street = "Ulica";

            //Console.WriteLine("Mieszkanie:");
            //int streetNumber = Convert.ToInt32(Console.ReadLine());
            int streetNumber = 9;

            //Console.WriteLine("Numer mieszkania/domu:");
            //int flat = Convert.ToInt32(Console.ReadLine());
            int flat = 9;

            //Console.WriteLine("Miasto:");
            //string city = Console.ReadLine();
            string city = "Wrocław";

            PersonalInfo person1 =
                new PersonalInfo(name, secondName, surname, isFemale, age, street, streetNumber, flat, city);


            PrintText(person1);



        }

        private static void PrintText(PersonalInfo personInfo)
        {
            Console.WriteLine($"{personInfo.Name} {personInfo.SecondName} {personInfo.Surname}");
            Console.WriteLine($"Ul. {personInfo.Street} {personInfo.StreetNumber} {personInfo.Flat} {personInfo.City}");
            Console.WriteLine(Salutation(personInfo.Age, personInfo.Name, personInfo.IsFemale));
            Console.WriteLine("Zapraszamy {0} serdecznie na otwarcie naszego sklepu!", ShortSalutation(personInfo));
            Console.WriteLine("Powitamy {0} {1}.", ShortSalutation(personInfo), Champagne(personInfo));
            Bingo(personInfo);
            Console.WriteLine(Farewell(personInfo));
        }

        private static string ShortSalutation(PersonalInfo personInfo)
        {
            var shortSalutation = "";
            if (personInfo.IsFemale == true && personInfo.Age >= 18)
            {
                shortSalutation = "Panią";
            }
            if (personInfo.IsFemale == false && personInfo.Age >= 18)
            {
                shortSalutation = "Pana";
            }
            if (personInfo.Age < 18)
            {
                shortSalutation = "Cię";
            }

            return shortSalutation;
        }

        private static string Farewell(PersonalInfo personInfo)
        {
            var farewell = "";
            if (personInfo.Age > 60)
            {
                farewell = "z wyrazami szacunku";
            }
            if (personInfo.Age >= 18 && personInfo.IsFemale)
            {
                farewell = "czekamy na Panią.";
            }
            if (personInfo.Age >= 18 && personInfo.IsFemale == false)
            {
                farewell = "czekamy na Pana.";
            }
            if (personInfo.Age < 18 )
            {
                farewell = "do zobaczenia.";
            }

            return farewell;
        }

        private static string Champagne(PersonalInfo personInfo)
        {
            var champagne = "";
            champagne = personInfo.Age >= 18 ? "kieliszkiem szampana" : "kubkiem gorącej czekolady";
            return champagne;
        }

        private static void Bingo(PersonalInfo personInfo)
        {
            if (personInfo.Age > 60)
            {
                Console.WriteLine("I zapraszamy do gry w bingo");
            }
        }

        private static bool IsWoman(string name)
        {
            var isWoman = name.EndsWith("a");

            return isWoman;
        }

        private static string Salutation(int age, string name, bool isFemale)
        {
            string salutation = "";
            if (age >= 18 && isFemale)
            {
                salutation = "Szanowna Pani";
            }
            if (age >= 18 && isFemale == false)
            {
                salutation = "Szanowny Panie";
            }

            return salutation;
        }

    }
}
