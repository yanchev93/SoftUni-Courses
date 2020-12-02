using System;

namespace _03.GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            string output = string.Empty;
            decimal totalSpent = 0.00m;

            decimal OutFall4 = 39.99m;
            decimal CSOG = 15.99m;
            decimal ZplinterZell = 19.99m;
            decimal Honored2 = 59.99m;
            decimal RoverWatch = 29.99m;
            decimal RoverWatchOE = 39.99m;

            string command = Console.ReadLine();
            while (command != "Game Time")
            {
                

                bool isValid = command == "OutFall 4" || command == "CS: OG" || command == "Zplinter Zell"
                    || command == "Honored 2" || command == "RoverWatch" || command == "RoverWatch Origins Edition";

                if (isValid)
                {
                    if (command == "OutFall 4" && currentBalance >= OutFall4)
                    {
                        totalSpent += OutFall4;
                        currentBalance -= OutFall4;
                        output = $"Bought {command}";
                    }
                    else if (command == "CS: OG" && currentBalance >= CSOG)
                    {
                        totalSpent += CSOG;
                        currentBalance -= CSOG;
                        output = $"Bought {command}";
                    }
                    else if (command == "Zplinter Zell" && currentBalance >= ZplinterZell)
                    {
                        totalSpent += ZplinterZell;
                        currentBalance -= ZplinterZell;
                        output = $"Bought {command}";
                    }
                    else if (command == "Honored 2" && currentBalance >= Honored2)
                    {
                        totalSpent += Honored2;
                        currentBalance -= Honored2;
                        output = $"Bought {command}";
                    }
                    else if (command == "RoverWatch" && currentBalance >= RoverWatch)
                    {
                        totalSpent += RoverWatch;
                        currentBalance -= RoverWatch;
                        output = $"Bought {command}";
                    }
                    else if (command == "RoverWatch Origins Edition" && currentBalance >= RoverWatchOE)
                    {
                        totalSpent += RoverWatchOE;
                        currentBalance -= RoverWatchOE;
                        output = $"Bought {command}";
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }

                Console.WriteLine(output);

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
