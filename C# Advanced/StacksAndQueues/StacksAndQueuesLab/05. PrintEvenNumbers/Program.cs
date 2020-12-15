using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ')
                                              .Select(int.Parse)
                                              .ToArray();
            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < arrNums.Length; i++)
            {

                if (arrNums[i] % 2 == 0)
                {
                    nums.Enqueue(arrNums[i]);
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
