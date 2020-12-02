using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                               .Split()
                               .Select(double.Parse)
                               .ToArray();
            int numbersLength = numbers.Length;
            

            for (int i = 0; i < numbersLength; i++)
            {
                int arrayNumbers = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {arrayNumbers}");
            }
        }
    }
}
