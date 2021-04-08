using System;
using System.Numerics;

namespace _03._ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
