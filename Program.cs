using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "t3k$t d0 prz3k$zt4łc3n14";
            string textToEncrypt = "tekst do przekształcenia";
            Encrypt(textToEncrypt);
            Decrypt(text);

        }

        private static void Decrypt(string text)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
            char[] txt = new char[text.Length];

            string decrypted = text;

            for (int i = 0; i < text.Length -1; i++)
            {
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    decrypted = decrypted.Replace(leetLetters[j], naturalLetters[j]);
                }
                
            }

            //Console.WriteLine(text);
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
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    encrypted = encrypted.Replace(naturalLetters[i], leetLetters[i]);
                }
                
            }

            //Console.WriteLine(text);
            Console.WriteLine(encrypted);


        }
    }
}
