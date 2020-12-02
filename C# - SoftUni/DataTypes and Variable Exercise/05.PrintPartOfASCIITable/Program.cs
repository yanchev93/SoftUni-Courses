using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstAsciiValue = int.Parse(Console.ReadLine());
            int secondAsciiValue = int.Parse(Console.ReadLine());
            

            for (int i = firstAsciiValue; i <= secondAsciiValue; i++)
            {
                char chr = (char)(i);
                Console.Write($"{chr} ");
            }
        }
    }
}
