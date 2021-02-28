namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] currCommand = command
                        .Split(';', StringSplitOptions.RemoveEmptyEntries);

                    string args = currCommand[0].ToLower();
                    string teamName = currCommand[1];


                    if (args == "team")
                    {
                        Team team = new Team(teamName);

                        teams.Add(team);
                    }

                    Team tryTeam = teams.FirstOrDefault(t => t.Name == teamName);
                    if (tryTeam == null)
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");

                        command = Console.ReadLine();
                        continue;
                    }
                    else if (args == "add")
                    {
                        Team team = teams.FirstOrDefault(n => n.Name == teamName);

                        string playerName = currCommand[2];
                        int endurance = int.Parse(currCommand[3]);
                        int sprint = int.Parse(currCommand[4]);
                        int dribble = int.Parse(currCommand[5]);
                        int passing = int.Parse(currCommand[6]);
                        int shooting = int.Parse(currCommand[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (team != null)
                        {
                            team.Add(player);
                        }
                        else
                        {
                            string excNameTeam = $"Team {teamName} does not exist.";

                            throw new ArgumentException(excNameTeam);
                        }
                    }
                    else if (args == "remove")
                    {
                        Team team = teams.FirstOrDefault(n => n.Name == teamName);

                        string playerName = currCommand[2];

                        if (team != null)
                        {
                            team.Remove(playerName, teamName);
                        }
                        else
                        {
                            string excNameTeam = $"Team {teamName} does not exist.";

                            throw new ArgumentException(excNameTeam);
                        }
                    }
                    else if (args == "rating")
                    {
                        Team team = teams.FirstOrDefault(n => n.Name == teamName);

                        if (team != null)
                        {
                            Console.WriteLine(team.ToString());
                        }
                        else
                        {
                            string excNameTeam = $"Team {teamName} does not exist.";

                            throw new ArgumentException(excNameTeam);
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
    }
}
