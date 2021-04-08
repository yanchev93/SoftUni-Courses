using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(SumOfTwoStrings(input));
        }

        static int SumOfTwoStrings(string[] input)
        {
            string longer = string.Empty;
            string shorter = string.Empty;

            if (input[0].Length > input[1].Length)
            {
                longer = input[0];
                shorter = input[1];
            }

            else
            {
                longer = input[1];
                shorter = input[0];
            }

            int sum = 0;

            for (int i = 0; i < shorter.Length; i++)
            {
                sum += longer[i] * shorter[i];
            }

            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }

            return sum;

        }
    }
}
