using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class Program
    {
        static void Main()
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> safeDrumSet = drumSet.ToList();
            decimal price = 0m;
            
            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if (drumSet[i] <= 0)
                    {
                        price = safeDrumSet[i] * 3;
                        if (savings < price)
                        {
                            drumSet.RemoveAt(i);
                            safeDrumSet.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumSet.Insert(i, safeDrumSet[i]);
                            savings -= price;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
