using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.HouseParty
{
    class HouseParty
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> nameGuests = Console.ReadLine()
                                    .Split()
                                    .ToList();
                                          
                if (nameGuests[2] == "not")
                {
                    if (guests.Contains(nameGuests[0]))
                    {
                        guests.Remove(nameGuests[0]);
                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"{nameGuests[0]} is not in the list!");
                        continue;
                    }
                    
                }

                else
                {
                    if (guests.Contains(nameGuests[0]))
                    {
                        Console.WriteLine($"{nameGuests[0]} is already in the list!");
                        continue;
                    }

                    else
                    {
                        guests.Add(nameGuests[0]);
                    }
                }
            }

            Console.WriteLine(string.Join($"\n", guests));
        }
    }
}
