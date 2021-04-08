using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_AssociativeArrays___Dictionaries__
{
    class CountCharInAString
    {
        static void Main()
        {
            Dictionary<char, int> dictLetters = new Dictionary<char, int>();

            string command = Console.ReadLine();
            for (int i = 0; i < command.Length; i++)
            {
                char letter = command[i];

                if (letter != ' ')
                {
                    if (!dictLetters.ContainsKey(letter))
                    {
                        dictLetters[letter] = 0;
                    }

                    dictLetters[letter] += 1;
                }
            }

            foreach (var letter in dictLetters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
