using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2\1(\d{3})\1(\d{4})\b";

            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);

            var matchedPhones = matches
                                .Cast<Match>()
                                .Select(a => a.Value.Trim())
                                .ToArray();

            Console.WriteLine($"{string.Join(", ", matchedPhones)} ");
        }
    }
}
