using System;
using System.Numerics;

namespace _02._BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factBI = Factorial.Calculate(n);

            Console.WriteLine(factBI);
        }
    }

    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= 1;
            }

            return result;
        }
    }
}
