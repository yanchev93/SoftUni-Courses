using System;
using System.Linq;

namespace _02._SumNumbers
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = numbers.Count();
            int sum = numbers.Sum();

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
