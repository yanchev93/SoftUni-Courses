using System;

namespace _4.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();

                sum += Char.Parse(letter);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
