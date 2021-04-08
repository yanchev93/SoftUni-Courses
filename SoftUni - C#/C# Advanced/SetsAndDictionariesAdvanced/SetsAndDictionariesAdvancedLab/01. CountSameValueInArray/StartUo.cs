using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountSameValueInArray
{
    class StartUo
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var valueDict = new Dictionary<string, int>();

            foreach (var value in values)
            {
                if (!valueDict.ContainsKey(value))
                {
                    valueDict[value] = 0;
                }

                valueDict[value] += 1;
            }

            PrintDict(valueDict);
        }

        private static void PrintDict(Dictionary<string, int> valueDict)
        {
            foreach (var (name, value) in valueDict)
            {
                Console.WriteLine($"{name} - {value} times");
            }
        }
    }
}
