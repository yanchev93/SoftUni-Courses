using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int instruction = input[0];

                if (instruction == 1)
                {
                    stack.Push(input[1]);
                }

                else if (instruction == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }

                else if (instruction == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }

                else if (instruction == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
