using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = RectangleArea(a, b);

            Console.WriteLine(result);
        }

        static double RectangleArea(double a, double b)
        {
            double result = a * b;
            return result;
        }
    }
}
