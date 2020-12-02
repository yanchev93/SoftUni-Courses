using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var hatColorWithNamesAndPhysics = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArray = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToArray();
                string name = inputArray[0];
                string hatColor = inputArray[1];
                int physics = int.Parse(inputArray[2]);

                if (hatColorWithNamesAndPhysics.ContainsKey(hatColor) == false)
                {
                    hatColorWithNamesAndPhysics[hatColor] = new Dictionary<string, int>();
                    hatColorWithNamesAndPhysics[hatColor].Add(name, physics);
                }

                else if (hatColorWithNamesAndPhysics.ContainsKey(hatColor) == true)
                {
                    bool haveDwarfWithTheSameName = false;
                    foreach (var kvp in hatColorWithNamesAndPhysics[hatColor])
                    {
                        string currentName = kvp.Key;
                        int currentPhysics = kvp.Value;
                        if (currentName == name)
                        {
                            haveDwarfWithTheSameName = true;
                            if (physics > currentPhysics)
                            {
                                hatColorWithNamesAndPhysics[hatColor][currentName] = physics;
                                break;
                            }
                        }
                    }

                    if (haveDwarfWithTheSameName == false)
                    {
                        hatColorWithNamesAndPhysics[hatColor].Add(name, physics);
                    }
                }
            }

            var sortedDwarf = new Dictionary<string, int>();
            foreach (var kvp in hatColorWithNamesAndPhysics.OrderByDescending(x => x.Value.Count()))
            {
                string hatColor = kvp.Key;
                var namesAndPhysics = kvp.Value;
                foreach (var kvp1 in namesAndPhysics)
                {
                    string name = kvp1.Key;
                    int physic = kvp1.Value;
                    sortedDwarf.Add($"({hatColor}) {name} <-> ", physic);
                }
            }

            foreach (var kvp in sortedDwarf.OrderByDescending(x => x.Value))
            {
                string name = kvp.Key;
                int physic = kvp.Value;
                Console.WriteLine($"{name}{physic}");
            }
        }
    }
}

