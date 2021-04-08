using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Race
    {
        static void Main()
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            List<string> validParticipants = Console.ReadLine()
                                             .Split(", ")
                                             .ToList();

            string namePattern = @"[A-Za-z]";
            string digitsPattern = @"\d";

            string command = Console.ReadLine();
            while (command != "end of race")
            {
                var nameMatches = Regex.Matches(command, namePattern);
                var digitsMatches = Regex.Matches(command, digitsPattern);

                string name = string.Concat(nameMatches);
                var sum = digitsMatches.Select(x => int.Parse(x.Value)).Sum();

                if (validParticipants.Contains(name))
                {
                    if (!participants.ContainsKey(name))
                    {
                        participants[name] = 0;
                    }

                    participants[name] += sum;
                }

                command = Console.ReadLine();
            }

            var sorted = participants
                         .OrderByDescending(x => x.Value)
                         .Select(x => x.Key)
                         .Take(3)
                         .ToList();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
