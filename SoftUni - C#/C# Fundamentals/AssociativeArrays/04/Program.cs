using System;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var Largest3Numbers = numbers.OrderByDescending(x => x);

            Console.WriteLine($"{string.Join(' ', Largest3Numbers.Take(3))}");
        }
    }
}
