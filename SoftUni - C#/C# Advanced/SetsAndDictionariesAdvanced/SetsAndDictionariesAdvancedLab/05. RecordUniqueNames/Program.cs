using System;
using System.Collections.Generic;

namespace _05._RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                uniqueNames.Add(input);
            }

            Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
        }
    }
}
