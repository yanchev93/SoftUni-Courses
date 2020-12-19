using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char parenthesis = input[i];

                if (parenthesis == '(' || parenthesis == '[' || parenthesis == '{')
                {
                    stack.Push(parenthesis);
                }

                else if ((parenthesis == ')' && stack.Peek() == '(')
                        || (parenthesis == ']' && stack.Peek() == '[')
                        || (parenthesis == '}' && stack.Peek() == '{'))
                {
                    stack.Pop();
                }

                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }


            Console.WriteLine("YES");
        }
    }
}
