using System;
using System.Collections.Generic;

namespace _03._CountUppercaseWords
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            List<string> words = new List<string>();
            foreach (var word in input)
            {
                if (char.IsUpper(word[0]))
                {
                    words.Add(word);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
