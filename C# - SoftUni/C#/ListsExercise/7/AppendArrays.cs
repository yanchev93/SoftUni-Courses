using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class AppendArrays
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                          .Split('|', StringSplitOptions.RemoveEmptyEntries)
                          .ToList();

            List<string> output = new List<string>();
            List<int> numbers = new List<int>();

            for (int i = input.Count - 1; i >= 0 ; i--)
            {
                output.AddRange(input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList());

            }

            Console.WriteLine(string.Join(' ', output));
        }
    }
}
