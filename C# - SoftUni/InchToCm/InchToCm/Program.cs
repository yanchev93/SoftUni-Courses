using System;

namespace InchToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;
            double a = double.Parse(Console.ReadLine());
            double convertor = inch * a;
            Console.WriteLine(convertor);

        }
    }
}
