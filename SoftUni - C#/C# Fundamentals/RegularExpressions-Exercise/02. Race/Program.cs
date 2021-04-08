using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = @"[A-Za-z]+";
            string km = @"\d";

            string[] participants = Console.ReadLine().Split(", ");
            var contestants = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection matchName = Regex.Matches(input, name);
                MatchCollection matchKM = Regex.Matches(input, km);

                string currentName = string.Concat(matchName);
                int sum = matchKM.Select(x => int.Parse(x.Value)).Sum();

                if (participants.Contains(currentName))
                {
                    if (contestants.ContainsKey(currentName))
                    {
                        contestants[currentName] += sum;
                    }

                    else
                    {
                        contestants.Add(currentName, sum);
                    }
                }

                input = Console.ReadLine();
            }

            List<string> output = contestants.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine($"1st place: {output[0]}");
            Console.WriteLine($"2nd place: {output[1]}");
            Console.WriteLine($"3rd place: {output[2]}");
        }
    }
}
