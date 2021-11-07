using System;
using System.Linq;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj hasło");
            string passwd = Console.ReadLine();
            PasswdComp(passwd);
        }

        private static void PasswdComp(string passwd)
        {
            bool islenght = false, isUpper = false, isLower = false, IsDigit = false, containsSpecial = false;
            char[] passwdarr = passwd.ToCharArray();
            if (passwd.Length <6)
            {
                Console.WriteLine("Hasło jest za krótkie");
            }
            else
            {
                islenght = true;
            }

            if (passwd.Any(char.IsUpper))
            {
                isUpper = true;
            }
            else
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jedną dużą literę");
            }

            if (passwd.Any(char.IsLower))
            {
                isLower = true;
            }
            else
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jedną małą literę");
            }

            if (passwd.Any(char.IsDigit))
            {
                IsDigit = true;
            }
            else
            {
                Console.WriteLine("Hasło musi zawierać conajmniej jedną cyfrę");
            }
            string[] cont = {"&", "*","$" ,"#"};
            if (cont.Any(passwd.Contains))
            {
                containsSpecial = true;
            }
            else
            {
                Console.WriteLine("Hasło musi zawierać najmniej jeden znak specjalny spośród następujących: &*$#");
            }

            if (islenght && isUpper && isLower && IsDigit && containsSpecial == true)
            {
                Console.WriteLine("Podane hasło spełnia wymogi");
            }
        }
    }
}
//Dla podanego ciągu znaków oznaczającego hasło, sprawdź, czy spełnia on następujące warunki
//złożoności hasła:

//• długość co najmniej 6 znaków
//• występują co najmniej jedna duża i jedna mała litera
//• występuje co najmniej jedna cyfra
//• występuje co najmniej jeden znak specjalny spośród następujących: &*$#