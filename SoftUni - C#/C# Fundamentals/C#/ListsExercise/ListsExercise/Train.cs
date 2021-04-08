using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ListsExercise
{
    class Train
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> line = Console.ReadLine()
                          .Split()
                          .ToList();            
            while (line[0] != "end")
            {

                if (line[0] == "Add")
                {
                    if (int.Parse(line[1]) <= maxCapacity)
                    {
                        wagons.Add(int.Parse(line[1]));
                    }
                    else
                    {
                        line = Console.ReadLine()
                               .Split()
                               .ToList();
                        continue;
                        
                    }
                }

                else
                {
                    int lineNumber = int.Parse(line[0]);
                    int PassengersInWagons = 0;
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int diffInPassengers = maxCapacity - wagons[i];

                        if (lineNumber <= diffInPassengers)
                        {
                            PassengersInWagons = lineNumber + wagons[i];
                            wagons.Insert(i, PassengersInWagons);
                            wagons.RemoveAt(i + 1);
                            break;
                        }
                    }
                }

                line = Console.ReadLine()
                               .Split()
                               .ToList();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
