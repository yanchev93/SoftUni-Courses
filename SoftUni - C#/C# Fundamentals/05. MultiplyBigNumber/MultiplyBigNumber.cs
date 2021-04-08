using System;
using System.Dynamic;

namespace _05._MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyTheString(number, multiplyer));
        }

        static string MultiplyTheString(string number, int multiplyer)
        {
            string sum = string.Empty;

            string keepInMind = string.Empty;
            for (int i = number.Length - 1; i >= 0; i++)
            {
                int num1 = number[i];

                sum += ;
            }



            return sum;
        }
    }
}
