using System;
using System.Collections.Generic;

namespace _07._SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipList = new HashSet<string>();
            var regularList = new HashSet<string>();

            string command = Console.ReadLine();
            while (command != "PARTY")
            {
                int length = command.Length;

                if (length == 8)
                {
                    if (char.IsDigit(command[0]))
                    {
                        vipList.Add(command);
                    }
                    else
                    {
                        regularList.Add(command);
                    }
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "END")
            {
                if (vipList.Contains(command))
                {
                    vipList.Remove(command);
                }

                else if (regularList.Contains(command))
                {
                    regularList.Remove(command);
                }

                command = Console.ReadLine();
            }

            int notShowedGuests = vipList.Count + regularList.Count;
            Console.WriteLine(notShowedGuests);
            if (vipList.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipList));
            }

            if (regularList.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularList));
            }
        }
    }
}
