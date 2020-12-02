using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string regex = @"(?<=^| )\+359([ -])2\2\d{3}\2\d{4}\b";

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches
                                .Cast<Match>()
                                .Select(a => a.Value.Trim())
                                .ToArray();
        
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
