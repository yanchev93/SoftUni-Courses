using System;
using System.Globalization;
using System.Text;

namespace _06._ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReplaceRepeatingCharecters(input));
        }

        static string ReplaceRepeatingCharecters(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    sb.Append(input[i - 1]);
                }
            }
            sb.Append(input[input.Length - 1]);    
            string output = sb.ToString();
            return output;
        }

    }
}
