using System;
using System.Text;

namespace _06._ReplaceRepeatingCharecters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i-1] != input[i])
                {
                    output.Append(input[i - 1]);
                }

                if (i == input.Length - 1)
                {
                    output.Append(input[i]);
                }
            }

            Console.WriteLine(output);
        }
    }
}
