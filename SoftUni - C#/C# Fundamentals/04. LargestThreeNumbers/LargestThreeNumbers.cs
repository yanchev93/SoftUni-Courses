using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> sorted = numbers.OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join(' ', sorted.Take(3)));

        }
    }
}
