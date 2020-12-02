using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teamDict = new ListOfTeams();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-',
                    StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string teamName = input[1];

                if (teamDict.TeamsDict.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                else if (teamDict.TeamsDict.Any(x => x.Value.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                else
                {
                    CurrentTeam currentTeam = new CurrentTeam(creator);
                    teamDict.TeamsDict.Add(teamName, currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string members;
            while ((members = Console.ReadLine()) != "end of assignment")
            {
                string[] currentMember = members.Split("->",
                StringSplitOptions.RemoveEmptyEntries);
                string member = currentMember[0];
                string teamName = currentMember[1];

                if (!teamDict.TeamsDict.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                else if (teamDict.TeamsDict.Any(m => m.Value.Members.Contains(member))
                    || teamDict.TeamsDict.Any(c => c.Value.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                teamDict.TeamsDict[teamName].Members.Add(member);
            }

            foreach (var kvp in teamDict.TeamsDict
                .OrderByDescending(x => x.Value.Members.Count)
                .ThenBy(n => n.Key))
            {
                var teamName = kvp.Key;
                var value = kvp.Value;
                value.Members.Sort();

                if (value.Members.Count > 0)
                {
                    Console.WriteLine($"{teamName}");
                    Console.WriteLine($"- {value.Creator}");
                    Console.WriteLine($"-- {string.Join($"{Environment.NewLine}-- ", value.Members)}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamDict.TeamsDict
                .OrderByDescending(x => x.Value.Members.Count)
                .OrderBy(n => n.Key))
            {
                var key = team.Key;
                var value = team.Value;

                if (value.Members.Count == 0)
                {
                    Console.WriteLine(key);
                }
            }
        }

        public class CurrentTeam
        {
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public CurrentTeam(string creator)
            {
                this.Creator = creator;
                Members = new List<string>();
            }
        }

        public class ListOfTeams
        {
            public Dictionary<string, CurrentTeam> TeamsDict { get; set; }
            public ListOfTeams()
            {
                this.TeamsDict = new Dictionary<string, CurrentTeam>();
            }
        }
    }
}
