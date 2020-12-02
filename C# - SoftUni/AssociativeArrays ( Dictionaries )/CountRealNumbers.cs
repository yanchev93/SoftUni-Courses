using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays___Dictionaries__
{
    class CountRealNumbers
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToList();

            var countRealNums = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!countRealNums.ContainsKey(number))
                {
                    countRealNums[number] = 0;
                }

                countRealNums[number] += 1;
            }

            foreach (var item in countRealNums)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
