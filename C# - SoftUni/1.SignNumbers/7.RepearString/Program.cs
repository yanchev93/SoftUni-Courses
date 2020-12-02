using System;

namespace _7.RepearString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());

            string output = RepeatString(input, repeatNumber);

            Console.Write(output);
        }

        static string RepeatString(string input, int repeatNumber)
        {
            string output = string.Empty;
            for (int i = 0; i < repeatNumber; i++)
            {
                output += input;
            }

            return output;
        }
    }
}
