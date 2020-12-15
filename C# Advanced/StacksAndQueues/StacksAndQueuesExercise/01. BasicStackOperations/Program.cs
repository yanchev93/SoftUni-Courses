using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int push = input[0];
            int pop = input[1];
            int search = input[2];

            int minNum = int.MaxValue;
            for (int i = 0; i < push; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(search))
            {
                Console.WriteLine("true");
            }

            else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
