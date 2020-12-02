using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TeamProjectNewTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-',
                    StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                else if (teams.Any(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot creat another team!");
                    continue;
                }

                Team currentTeam = new Team(teamName, creator);
                Console.WriteLine($"Team {teamName} has been created by {creator}");

                teams.Add(currentTeam);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] currentInput = input.Split("->",
                    StringSplitOptions.RemoveEmptyEntries);
                string member = currentInput[0];
                string teamName = currentInput[1];

                if (!teams.Any(t => t.TeamName != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                else if (teams.Any(m => m.Members.Contains(member))
                    || teams.Any(c=> c.Creator.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                int index = teams.FindIndex(i=>i.TeamName == teamName);
                teams[index].Members.Add(member);
            }



        }

        public class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string teamName, string creator)
            {
                this.TeamName = teamName;
                this.Creator = creator;
                Members = new List<string>();
            }
        }
    }
}
