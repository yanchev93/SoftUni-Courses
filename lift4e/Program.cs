using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int WaitingPll = int.Parse(Console.ReadLine());
            List<int> pplInWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isEmpty = false;
            for (int i = 0; i < pplInWagons.Count; i++)
            {
                if (WaitingPll == 0)
                {
                    break;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (pplInWagons[i] == 4 || WaitingPll == 0)
                    {
                        break;
                    }

                    pplInWagons[i] += 1;
                    WaitingPll -= 1;

                }
            }

            for (int i = 0; i < pplInWagons.Count; i++)
            {
                if (pplInWagons[i] < 4)
                {
                    isEmpty = true;
                }
            }


            if (WaitingPll > 0)
            {
                Console.WriteLine($"There isn't enough space! {WaitingPll} people in a queue!");
                Console.WriteLine(string.Join(' ', pplInWagons));
            }
            else if (isEmpty)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', pplInWagons));
            }
            else
            {
                Console.WriteLine(string.Join(' ', pplInWagons));
            }
        }
    }
}
