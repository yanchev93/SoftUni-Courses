using System;
using System.Collections.Generic;

namespace FinalExam_13._12._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = currentCommand[0];

                if (instruction == "Change")
                {
                    string chr = currentCommand[1];
                    string replacement = currentCommand[2];

                    input = input.Replace(chr, replacement);

                    Console.WriteLine(input);
                }

                else if (instruction == "Includes")
                {
                    string includes = currentCommand[1];

                    if (input.Contains(includes))
                    {
                        Console.WriteLine("True");
                    }

                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (instruction == "End")
                {
                    string ends = currentCommand[1];

                    if (input.EndsWith(ends))
                    {
                        Console.WriteLine("True");
                    }

                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (instruction == "Uppercase")
                {
                    input = input.ToUpper();

                    Console.WriteLine(input);
                }

                else if (instruction == "FindIndex")
                {
                    string chr = currentCommand[1];

                    int index = input.IndexOf(chr);

                    Console.WriteLine(index);
                }

                else if (instruction == "Cut")
                {
                    int startIndex = int.Parse(currentCommand[1]);
                    int length = int.Parse(currentCommand[2]);

                    input = input.Substring(startIndex, length);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

        }

        
    }
}
