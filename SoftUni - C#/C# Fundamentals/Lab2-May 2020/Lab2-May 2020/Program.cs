using System;

namespace Lab2_May_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float  kilometers = meters * 0.001f;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
