using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static Dictionary<char, string> morseToChar = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},

            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},

            {' ', "|"},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {':', "---..."},
            {'?', "..--.."},
            {'!', "..--."},
            {'\'', ".----."},
            {'-', "-....-"},
            {'/', "-..-."},
            {'"', ".-..-."},
            {'@', ".--.-."},
            {'=', "-...-"},
        };

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Trim().Split(' ');
            StringBuilder output = new StringBuilder();
            foreach (string s in input)
            {
                if (morseToChar.ContainsValue(s))
                {
                    output.Append(morseToChar.FirstOrDefault(x => x.Value == s).Key);
                }
            }
                
            Console.WriteLine(output.ToString().ToUpper());
        }
    }
}
