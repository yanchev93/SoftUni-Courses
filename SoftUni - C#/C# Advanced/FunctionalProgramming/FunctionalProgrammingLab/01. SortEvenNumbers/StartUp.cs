using System;
using System.Linq;

namespace _01._SortEvenNumbers
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] result = numbers.Where(num => num % 2 == 0).ToArray();

            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
