using System;
using System.Collections.Generic;
using System.Linq;

namespace dwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] currentInput = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = currentInput[0];
                string color = currentInput[1];
                int physic = int.Parse(currentInput[2]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new Dictionary<string, int>();

                    dict[name].Add(color, physic);
                }

                else if (!dict[name].ContainsKey(color))
                {
                    dict[name][color] = physic;
                }

                if (dict[name][color] < physic)
                {
                    dict[name][color] = physic;
                }


                input = Console.ReadLine();
            }

            var sortedDict = dict
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Key.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedDict)
            {
                var name = item.Key;
                var newDict = item.Value;

                foreach (var kvp in newDict)
                {
                    var color = kvp.Key;
                    var physic = kvp.Value;

                    Console.WriteLine($"({color}) {name} <-> {physic}");




                }

            }











        }
    }
}
