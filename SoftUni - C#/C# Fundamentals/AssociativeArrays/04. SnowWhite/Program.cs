using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SnowWhite
{
    class Program
    {
        static void Main()
        {
            var dictOfDwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] currentInput = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = currentInput[0];
                string dwarfHatColor = currentInput[1];
                int dwarfPhysic = int.Parse(currentInput[2]);

                if (!dictOfDwarfs.ContainsKey(dwarfHatColor))
                {

                    dictOfDwarfs[dwarfHatColor] = new Dictionary<string, int>();

                    dictOfDwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysic);

                }

                if (dictOfDwarfs[dwarfHatColor].ContainsKey(dwarfName)
                    && dictOfDwarfs[dwarfHatColor][dwarfName] < dwarfPhysic)
                {
                    dictOfDwarfs[dwarfHatColor][dwarfName] = dwarfPhysic;

                }

                else if (!dictOfDwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    dictOfDwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysic);

                }


                input = Console.ReadLine();                
            }

            dictOfDwarfs = dictOfDwarfs
                           .OrderByDescending(x => x.Value.Count())
                           .ToDictionary(x => x.Key, x => x.Value);

            var sortedDwarfs = new Dictionary<string, int>();

            foreach (var kvp in dictOfDwarfs)
            {
                var color = kvp.Key;
                var dwarfsNamesAndPhysics = kvp.Value;

                foreach (var dwarf in dwarfsNamesAndPhysics)
                {
                    var name = dwarf.Key;
                    var physic = dwarf.Value;

                    sortedDwarfs.Add($"({color}) {name} <-> ", physic);
                }
            }

            sortedDwarfs = sortedDwarfs
                           .OrderByDescending(x => x.Value)
                           .ToDictionary(x => x.Key, x => x.Value);


            foreach (var kvp in sortedDwarfs)
            {
                var colorAndName = kvp.Key;
                var physic = kvp.Value;

                Console.WriteLine($"{colorAndName}{physic}");
            }

        }
    }
}
