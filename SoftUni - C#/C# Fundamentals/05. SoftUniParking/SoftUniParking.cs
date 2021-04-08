using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUniParking
{
    class SoftUniParking
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> members = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string currentCommand = command[0];
                string username = command[1];

                if (currentCommand == "register")
                {
                    string plateNumber = command[2];

                    if (!members.ContainsKey(username))
                    {
                        members[username] = plateNumber;
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else
                {
                    if (!members.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        members.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, members.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}
