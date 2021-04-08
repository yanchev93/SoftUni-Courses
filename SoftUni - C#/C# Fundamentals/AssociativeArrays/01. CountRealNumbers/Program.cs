using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!dict.ContainsKey(list[i]))
                {
                    dict[list[i]] = 0;
                }

                dict[list[i]] += 1;

            }

            dict = dict.OrderBy(x => x.Key)
                   .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, dict.Select(x => $"{x.Key} -> {x.Value}")));

        }
    }
}
