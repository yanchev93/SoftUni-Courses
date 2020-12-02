using System;
using System.Data;
using System.Security.Cryptography;

namespace _3.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            float currentBalance = float.Parse(Console.ReadLine());

            float OUTFALL4 = 39.99f;
            float CSOG = 15.99f;
            float ZPLINTERZELL = 19.99f;
            float HONORED2 = 59.99f;
            float ROVERWATCH = 29.99f;
            float ROVERWATCHOE = 39.99f;
            float totalSpent = 0; 
            string notFound = "Not Found";
            string outOfMoney = "Out of money!";
            string tooExpensive = "Too Expensive";
            

            string command = Console.ReadLine();
            while (command != "Game Time")
            {
                string bought = $"Bought {command}";

                if (currentBalance > 0)
                {
                    if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2"
                        && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                    {
                        Console.WriteLine(notFound); ;
                        command = Console.ReadLine();
                        continue;
                    }

                    if (command == "OutFall 4")
                    {
                        if (currentBalance < OUTFALL4)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += OUTFALL4;
                            currentBalance -= OUTFALL4;
                        }
                    }
                    else if (command == "CS: OG")
                    {
                        if (currentBalance < CSOG)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += CSOG;
                            currentBalance -= CSOG;
                        }
                    }
                    else if (command == "Zplinter Zell")
                    {
                        if (currentBalance < ZPLINTERZELL)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += ZPLINTERZELL;
                            currentBalance -= ZPLINTERZELL;
                        }
                    }
                    else if (command == "Honored 2")
                    {
                        if (currentBalance < HONORED2)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += HONORED2;
                            currentBalance -= HONORED2;
                        }
                    }
                    else if (command == "RoverWatch")
                    {
                        if (currentBalance < ROVERWATCH)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += ROVERWATCH;
                            currentBalance -= ROVERWATCH;
                        } 
                    }
                    else if (command == "RoverWatch Origins Edition")
                    {
                        if (currentBalance < ROVERWATCHOE)
                        {
                            Console.WriteLine(tooExpensive);
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(bought);
                            totalSpent += ROVERWATCHOE;
                            currentBalance -= ROVERWATCHOE;
                        }                          
                    }                       
                        
                }

                else
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (currentBalance == 0.00)
            {
                Console.WriteLine(outOfMoney);
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
