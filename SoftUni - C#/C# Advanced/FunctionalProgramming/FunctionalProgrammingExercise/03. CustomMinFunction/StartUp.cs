using System;
using System.Linq;

namespace _03._CustomMinFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            Func<int, bool> smallestNumber = n => n < minNum;

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var num in numbers)
            {
                if (smallestNumber(num))
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
