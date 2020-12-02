using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace _9.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string valueOne = Console.ReadLine();
            string valueTwo = Console.ReadLine();

            if (value == "int")
            {
                int valueOneInt = int.Parse(valueOne);
                int valueTwoInt = int.Parse(valueTwo);
                int output = ValueInt(valueOneInt, valueTwoInt);
                Console.WriteLine(output);
            }

            else if (value == "char")
            {
                char valueOneChar = char.Parse(valueOne);
                char valueTwoChar = char.Parse(valueTwo);
                char output = ValueChar(valueOneChar, valueTwoChar);
                Console.WriteLine(output);
            }

            else if (value == "string")
            {
                string output = ValueString(valueOne, valueTwo);
                Console.WriteLine(output);
            }
        }

        static int ValueInt (int valueOne, int valueTwo)
        {
            int output = 0;

            if (valueOne > valueTwo)
            {
                output = valueOne;
            }
            else
            {
                output = valueTwo;
            }
            return output;
        }
        static char ValueChar(char valueOne, char valueTwo)
        {
            char output = 'a';

            if (valueOne > valueTwo)
            {
                output = valueOne;
            }
            else
            {
                output = valueTwo;
            }
            return output;
        }
        static string ValueString(string valueOne, string valueTwo)
        {
            string output = string.Empty;
            int valueOneNumber = 0;
            int valueTwoNumber = 0;

            for (int i = 0; i < valueOne.Length; i++)
            {
                valueOneNumber += (int)(valueOne[i]);
                valueTwoNumber += (int)(valueOne[i]);
            }

            if (valueOneNumber > valueTwoNumber)
            {
                output = valueOne;
            }
            else
            {
                output = valueTwo;
            }
            return output;
        }
    }
}
