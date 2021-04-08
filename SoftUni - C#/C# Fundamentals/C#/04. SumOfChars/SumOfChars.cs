using System;

namespace _04._SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int nLine = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < nLine; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
