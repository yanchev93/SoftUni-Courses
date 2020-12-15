using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> que = new Queue<int>(orders);

            Console.WriteLine(que.Max());

            while (qtyFood > 0 && que.Count > 0)
            {
                int foodOrder = que.Peek();
                if (qtyFood >= foodOrder && que.Count > 0)
                {
                    qtyFood -= que.Dequeue();
                }

                else
                {
                    break;
                }
            }

            if (que.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', que)}");
            }
        }
    }
}
