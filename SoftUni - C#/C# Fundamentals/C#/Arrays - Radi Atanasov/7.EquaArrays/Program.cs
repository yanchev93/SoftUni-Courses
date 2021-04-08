using System;
using System.Linq;

namespace _7.EquaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayNumbers = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            int[] secondArrayNumbers = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            int arraysSum = 0;
            int arraysLength = firstArrayNumbers.Length;
            int currentIndex = 0;
            bool isIdenticale = true;

            for (int i = 0; i < arraysLength; i++)
            {
                if (firstArrayNumbers[i] == secondArrayNumbers[i])
                {
                    arraysSum += firstArrayNumbers[i];
                }
                else
                {
                    isIdenticale = false;
                    currentIndex = i;
                    break;
                }
            }

            if (isIdenticale)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arraysSum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {currentIndex} index");
            }
        }
    }
}
