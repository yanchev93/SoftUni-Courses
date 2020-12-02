using System;

namespace _03._Substring
{
    class Program
    {
        static void Main()
        {
            string firstWord = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            while(word.Contains(firstWord))
            {
                int index = word.IndexOf(firstWord);

                word = word.Substring(index, firstWord.Length);
            }

            Console.WriteLine(word);
        }
    }
}
