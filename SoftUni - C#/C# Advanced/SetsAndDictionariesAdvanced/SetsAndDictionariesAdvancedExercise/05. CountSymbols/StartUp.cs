using System;
using System.Collections.Generic;

namespace _05._CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dictSymbols = new SortedDictionary<char, int>();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                char chr = input[i];
                if (!dictSymbols.ContainsKey(chr))
                {
                    dictSymbols[chr] = 0;
                }

                dictSymbols[chr] += 1;
            }

            foreach (var (@char, sum) in dictSymbols)
            {
                Console.WriteLine($"{@char}: {sum} time/s");
            }
        }
    }
}
