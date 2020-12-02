using System;

namespace _04._TextFiltering
{
    class TextFiltering
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                                 .Split(", ");
            string text = Console.ReadLine();

            foreach (var currentBannedWord in bannedWords)
            {
                text = text.Replace(currentBannedWord, new string('*', currentBannedWord.Length));

            }

            Console.WriteLine(text);
        }
    }
}
