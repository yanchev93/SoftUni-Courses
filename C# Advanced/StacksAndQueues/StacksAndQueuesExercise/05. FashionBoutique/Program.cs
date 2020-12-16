using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                                                       .Split(' ')
                                                       .Select(int.Parse)
                                                       .ToArray());
            int capacity = int.Parse(Console.ReadLine());

            int racks = 0;
            int sum = 0;

            while (clothes.Count > 0)
            {
                int currentCloth = clothes.Peek();

                if (currentCloth + sum <= capacity)
                {
                    sum += currentCloth;
                    clothes.Pop();
                }

                else
                {
                    sum = 0;
                    racks += 1;
                }
            }

            if (sum > 0)
            {
                racks += 1;
            }

            Console.WriteLine(racks);
        }
    }
}
