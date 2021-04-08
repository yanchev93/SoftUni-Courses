using System;

namespace _05._PrintParOfASCIITable
{
    class PrintParOfASCIITable
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
