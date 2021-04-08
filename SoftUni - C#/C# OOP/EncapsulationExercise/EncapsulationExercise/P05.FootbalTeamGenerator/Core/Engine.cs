
namespace P05.FootballTeamGenerator.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Engine : IEngine
    {
        private List<Team> teams;

        public void Run()
        {
            this.teams = new List<Team>();

            string command = Console.ReadLine();
            while (command != "END")
            {

                string[] currentCommand = command
                                          .Split(';', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    string instruction = currentCommand[0].ToLower();
                    string teamName = currentCommand[1];

                    if (instruction == "team")
                    {
                        Team team = new Team(teamName);

                        this.teams.Add(team);
                    }
                    else if (instruction == "add")
                    {
                        Team team = this.teams.FirstOrDefault(n => n.Name == teamName);

                        string playerName = currentCommand[2];
                        int endurance = int.Parse(currentCommand[3]);
                        int sprint = int.Parse(currentCommand[4]);
                        int dribble = int.Parse(currentCommand[5]);
                        int passing = int.Parse(currentCommand[6]);
                        int shooting = int.Parse(currentCommand[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (team != null)
                        {
                            team.Add(teamName, player);
                        }
                        else
                        {
                            InvalidTeam(teamName);
                        }
                    }
                    else if (instruction == "remove")
                    {
                        Team team = this.teams.FirstOrDefault(n => n.Name == teamName);

                        string playerName = currentCommand[2];

                        if (team != null)
                        {
                            team.Remove(playerName);
                        }
                        else
                        {
                            InvalidTeam(teamName);
                        }
                    }
                    else if (instruction == "rating")
                    {
                        Team team = this.teams.FirstOrDefault(n => n.Name == teamName);

                        if (team != null)
                        {
                            Console.WriteLine(team.ToString());
                        }
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

                command = Console.ReadLine();
            }
        }

        private static void InvalidTeam(string teamName)
        {
            string excInvalidTeam = string.Format(FootballExceptions.InvalidTeam, teamName);

            throw new ArgumentException(excInvalidTeam);
        }
    }
}
