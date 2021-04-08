using System;

namespace _02._AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChr = char.Parse(Console.ReadLine());
            char secondChr = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            Console.WriteLine(AsciiSum(firstChr, secondChr, text));
        }

        static int AsciiSum(char firstChr, char secondChr, string text)
        {
            int start = firstChr;
            int end = secondChr;

            if (firstChr > secondChr)
            {
                start = secondChr;
                end = firstChr;
            }

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int between = text[i];
                if (start < between && between < end)
                {
                    sum += between;
                }
            }

            return sum;
        }
    }
}
