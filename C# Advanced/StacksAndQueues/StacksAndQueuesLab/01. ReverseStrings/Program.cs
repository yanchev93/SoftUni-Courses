using System;
using System.Collections.Generic;

namespace _01._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charInput = input.ToCharArray();
            Stack<char> reverseInput = new Stack<char>(charInput);

            Console.WriteLine(string.Join("",reverseInput));
        }
    }
}
