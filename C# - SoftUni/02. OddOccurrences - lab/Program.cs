using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurrences___lab
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();

                if (!dict.ContainsKey(currentWord))
                {
                    dict[currentWord] = 0;
                }

                dict[currentWord] += 1;
            }

            foreach (var word in dict)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }

        }
    }
}
