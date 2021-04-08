using System;
using System.Collections.Generic;

namespace _04._EvenTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictEvenNums = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!dictEvenNums.ContainsKey(num))
                {
                    dictEvenNums[num] = 0;
                }

                dictEvenNums[num] += 1;
            }

            foreach (var num in dictEvenNums)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}
