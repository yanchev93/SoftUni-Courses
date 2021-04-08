using System;
using System.Linq;

namespace _6.EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int substractionResult = 0;
            int arrayLength = arrayNumbers.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayNumbers[i] % 2 != 0)
                {
                    oddSum += arrayNumbers[i];
                }
                else
                {
                    evenSum += arrayNumbers[i];
                }
            }
            substractionResult = evenSum - oddSum;
            Console.WriteLine(substractionResult);

        }
    }
}
