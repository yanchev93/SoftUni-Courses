using System;
using System.Collections.Generic;

namespace _01._UniqueUsernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
        }
    }
}
