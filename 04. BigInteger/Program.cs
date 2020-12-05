using System;
using System.Numerics;

namespace _04._BigInteger
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Factorial.Calculate(n);

            Console.WriteLine(result);
        }

        public class Factorial
        {
            public static BigInteger Calculate(int n)
            {
                BigInteger result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;

            }



        }
    }
}
