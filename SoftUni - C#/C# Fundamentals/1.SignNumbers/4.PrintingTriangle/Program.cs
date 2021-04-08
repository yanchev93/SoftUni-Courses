using System;
using System.IO;

namespace _4.PrintingTriangle
{
    class Program
    {
        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintInside(row);
            }

            for (int row = n - 1; row > 0; row--)
            {
                PrintInside(row);
            }

        }

        static void PrintInside(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

    }
}
