using System;
using System.Text;

namespace _04._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(EncryptedText(text));
        }

        static StringBuilder EncryptedText(string input)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                text.Append((char)(input[i] + 3));
            }

            return text;
        }
    }
}
