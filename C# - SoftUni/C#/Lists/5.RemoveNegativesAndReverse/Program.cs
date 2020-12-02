using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> postiveNumbers = new List<int>();
            bool isEmpty = false;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] >= 0)
                {
                    postiveNumbers.Add(numbers[i]);
                    isEmpty = true;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine(string.Join(" ", postiveNumbers));
            }

            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
