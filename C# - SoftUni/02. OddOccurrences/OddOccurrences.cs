using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            List<string> givenSequence = Console.ReadLine()
                                        .ToLower()
                                        .Split()
                                        .ToList();

            var dict = new Dictionary<string, int>();

            foreach (var word in givenSequence)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }

                dict[word] += 1;
            }

            foreach (var oddWord in dict)
            {
                if (oddWord.Value % 2 != 0)
                {
                    Console.Write($"{oddWord.Key} ");
                }
            }
        }
    }
}
