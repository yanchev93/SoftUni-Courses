using System;

namespace _04._CaesarCipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string output = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                output += (char)(text[i] + 3);
            }

            Console.WriteLine(output);
        }
    }
}
