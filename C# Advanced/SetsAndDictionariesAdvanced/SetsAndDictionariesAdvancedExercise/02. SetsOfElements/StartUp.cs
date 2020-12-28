using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetsOfElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstNumbers.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondNumbers.Add(number);
            }

            var minSet = firstNumbers.Count;

            if (minSet > secondNumbers.Count)
            {
                foreach (var num in secondNumbers)
                {
                    if (firstNumbers.Contains(num))
                    {
                        Console.Write(num + " ");
                    }
                }

                return;
            }

            foreach (var num2 in firstNumbers)
            {
                if (secondNumbers.Contains(num2))
                {
                    Console.Write(num2 + " ");
                }
            }


        }
    }
}
