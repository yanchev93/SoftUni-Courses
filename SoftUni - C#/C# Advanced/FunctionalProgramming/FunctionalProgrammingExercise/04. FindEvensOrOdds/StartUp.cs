using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindEvensOrOdds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Predicate<int> evenOrOdd = num => num % 2 == 0;

            int[] range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            
            int start = range[0];
            int end = range[1];

            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            if (command == "even")
            {
                numbers.RemoveAll(x => !evenOrOdd(x));
            }

            else
            {
                numbers.RemoveAll(evenOrOdd);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
