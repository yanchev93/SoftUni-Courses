using System;
using System.Collections.Generic;

namespace _04._MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int start = stack.Pop();

                    int length = i - start + 1;
                    string substr = input.Substring(start, length);

                    Console.WriteLine(substr);
                }
            }
         }
    }
}
