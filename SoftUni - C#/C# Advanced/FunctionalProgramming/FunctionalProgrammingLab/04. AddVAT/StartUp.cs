using System;
using System.Linq;

namespace _04._AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceWithoutVAT = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select((num) => double.Parse(num) * 1.20)
                .ToArray();

            foreach (var number in priceWithoutVAT)
            {
                Console.WriteLine($"{number:f2}");
            }

        }
    }
}
