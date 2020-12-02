using System;
using System.Dynamic;

namespace _2
{
    class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arrayNumbers[i] = numbers;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{arrayNumbers[i]} ");
            }
        }
    }
}
