using System;

namespace _02._CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(SumOfChars(input));
        }

        static int SumOfChars(string[] input)
        {
            string longest = input[0];
            string shortest = input[1];

            if (input[0].Length < input[1].Length)
            {
                longest = input[1];
                shortest = input[0];
            }

            int sum = 0;
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += longest[i] * shortest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
