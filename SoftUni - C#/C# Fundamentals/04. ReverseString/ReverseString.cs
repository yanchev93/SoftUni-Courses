using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }
    }
}
