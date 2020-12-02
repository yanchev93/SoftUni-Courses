using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._WordFilter
{
    class WordFilter
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            List<string> evenWords = words.Where(x => x.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join('\n', evenWords));
        }
    }
}
