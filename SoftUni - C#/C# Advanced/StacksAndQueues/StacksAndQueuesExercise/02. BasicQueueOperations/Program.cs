using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> que = new Queue<int>();

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int push = input[0];
            int pop = input[1];
            int search = input[2];

            int minNum = int.MaxValue;
            for (int i = 0; i < push; i++)
            {
                que.Enqueue(numbers[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                que.Dequeue();
            }

            if (que.Contains(search))
            {
                Console.WriteLine("true");
            }

            else
            {
                if (que.Count > 0)
                {
                    Console.WriteLine(que.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
