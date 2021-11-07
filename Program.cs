using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wagi = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            string pesel = "49040501580";
            Console.WriteLine(pesel);
            Console.WriteLine(ControlSum(pesel, wagi));
            
        }

        public static int ControlSum(string pesel, int[] wagi)
        {
            int[] id = new int[pesel.Length];
            int sum = 0;
            for (int i = 0; i < pesel.Length -1; i++)
            {
                sum += wagi[i] * id[i];
            }

            int s = sum % 10;

            if (s == 0)
                return 0;
            return 10 - s;


        }
    }
}
//E09

//Dla numeru PESEL podanego jako tekst, sprawdź, czy ma on poprawną cyfrę kontrolną zgodnie z
//algorytmem podanym na stronie
//pl.wikipedia.org/wiki/PESEL#Cyfra_kontrolna_i_sprawdzanie_poprawności_numeru
//Liczby, przez które mnożymy poszczególne cyfry numeru PESEL nazywają się wagami.
//Utwórz tablicę, w której zapiszesz te wagi i wykorzystaj tę tablicę do sprawdzenia poprawności
//cyfry kontrolnej.