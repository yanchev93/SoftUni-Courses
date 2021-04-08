using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._NumbersInRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fireCell = Console.ReadLine()
                           .Split(new Char[] { ' ', '=', '#'}, StringSplitOptions.RemoveEmptyEntries)                           
                           .ToList();
            List<int> fire = new List<int>();
            for (int i = 1; i < fireCell.Count; i += 2)
            {
                fire.Add(int.Parse(fireCell[i]));
                fireCell.RemoveAt(i);
                i--;
            }

            int amountOfWater = int.Parse(Console.ReadLine());
            int totalFire = 0;
            double effort = 0.00;
            List<int> cellsPutOut = new List<int>();
            for (int i = 0; i < fireCell.Count; i++)
            {
                if (fireCell[i] == "High" && (81 <= fire[i] && fire[i] <= 125))
                {
                    if (fire[i] > amountOfWater)
                    {
                        continue;
                    }

                    amountOfWater -= fire[i];
                    totalFire += fire[i];
                    effort += (fire[i] * 0.25);
                    cellsPutOut.Add(fire[i]);
                }
                else if (fireCell[i] == "Medium" && (51 <= fire[i] && fire[i] <= 80))
                {
                    if (fire[i] > amountOfWater)
                    {
                        continue;
                    }

                    amountOfWater -= fire[i];
                    totalFire += fire[i];
                    effort += (fire[i] * 0.25);
                    cellsPutOut.Add(fire[i]);
                }
                else if (fireCell[i] == "Low" && (1 <= fire[i] && fire[i] <= 50))
                {
                    if (fire[i] > amountOfWater)
                    {
                        continue;
                    }

                    amountOfWater -= fire[i];
                    totalFire += fire[i];
                    effort += (fire[i] * 0.25);
                    cellsPutOut.Add(fire[i]);
                }
            }

            Console.WriteLine("Cells: ");
            for (int i = 0; i < cellsPutOut.Count; i++)
            {
                Console.WriteLine($" - {cellsPutOut[i]}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
