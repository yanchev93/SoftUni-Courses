using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];
            }
            Console.Write($"{String.Join(" ",numbers)} ");
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
