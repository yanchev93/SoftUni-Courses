using System;
using System.Text.RegularExpressions;

namespace _03._MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<dd>\d{2})(?<sep>.)(?<MM>\w{3})\2(?<yyyy>\d{4})\b";

            string datesStrings = Console.ReadLine();

            var dates = Regex.Matches(datesStrings, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["dd"].Value;
                var month = date.Groups["MM"].Value;
                var year = date.Groups["yyyy"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
