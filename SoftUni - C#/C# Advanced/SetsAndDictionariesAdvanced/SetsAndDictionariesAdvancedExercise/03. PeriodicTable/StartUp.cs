using System;
using System.Collections.Generic;

namespace _03._PeriodicTable
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var chemical in input)
                {
                    chemicals.Add(chemical);
                }
            }

            Console.WriteLine(string.Join(' ', chemicals));
        }
    }
}
