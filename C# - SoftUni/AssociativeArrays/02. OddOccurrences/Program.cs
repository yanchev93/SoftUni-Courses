using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().ToList();
            var dictWords = new Dictionary<string, int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                string word = inputList[i].ToLower();
                if (!dictWords.ContainsKey(word))
                {
                    dictWords[word] = 0;
                }

                dictWords[word] += 1;
            }

            foreach (var word in dictWords)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
