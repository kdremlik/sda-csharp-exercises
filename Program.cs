using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "b3f0r3 3ncrypt10n";
            Encrypt(text);
            Decrypt(text);

        }

        private static void Decrypt(string text)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            char[] txt = new char[text.Length];

            string decrypted = text;

            for (int i = 0; i < text.Length; i++)
            {
                decrypted = decrypted.Replace(leetLetters[i], naturalLetters[i]);
            }

            Console.WriteLine(text);
            Console.WriteLine(decrypted);
        }


        private static void Encrypt(string text)
        {
            char[] leetLetters = {'4', '3', '1', '0', '$'};
            char[] naturalLetters = {'a', 'e', 'i', 'o', 's'};
            char[] txt = new char[text.Length];

            string encrypted = text;
            for (int i = 0; i < leetLetters.Length; i++)
            {
                encrypted = encrypted.Replace(naturalLetters[i], leetLetters[i]);
            }

            Console.WriteLine(text);
            Console.WriteLine(encrypted);


        }
    }
}
