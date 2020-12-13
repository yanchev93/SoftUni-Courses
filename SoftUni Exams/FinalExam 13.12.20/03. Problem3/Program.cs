using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] currentCommand = command.Split("->",
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = currentCommand[0];
                string userName = currentCommand[1];

                if (instruction == "Add")
                {
                    if (dict.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }

                    else
                    {
                        dict[userName] = new List<string>();
                    }
                }

                else if (instruction == "Send")
                {
                    string email = currentCommand[2];

                    dict[userName].Add(email);
                }

                else if (instruction == "Delete")
                {
                    if (dict.ContainsKey(userName))
                    {
                        dict.Remove(userName);
                    }

                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }

                }

                command = Console.ReadLine();
            }

            int countUsers = dict.Count;

            dict = dict.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Users count: {countUsers}");
            foreach (var user in dict)
            {
                string userName = user.Key;
                List<string> emails = user.Value;

                Console.WriteLine(userName);
                foreach (var email in emails)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
