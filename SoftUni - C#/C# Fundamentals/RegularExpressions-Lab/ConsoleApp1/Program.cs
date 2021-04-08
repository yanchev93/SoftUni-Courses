using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match name in match)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
