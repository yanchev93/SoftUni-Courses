using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            int length = nums.Length - 1;

            while (length > 0)
            {
                int[] condensed = new int[length];
                for (int i = 0; i < length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;

                length -= 1;
            }

            Console.WriteLine($"{nums[0]}");
        }
    }
}
