using System;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double output = Power(number, power);
            Console.WriteLine(output);
        }

        static double Power(double number, int power)
        {
            double output = 1;
            for (int i = 0; i < power; i++)
            {
                output *= number;
            }
            return output;
        }
    }
}
