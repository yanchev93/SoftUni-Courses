using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries));
            int count = 1;
            // List<string> children = Console.ReadLine().Split(' ',
            //     StringSplitOptions.RemoveEmptyEntries).ToList();

            int potato = int.Parse(Console.ReadLine());
            while (kids.Count != 1)
            {
                for (int i = 1; i < potato; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
