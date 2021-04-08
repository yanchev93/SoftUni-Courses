using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<string> command = Console.ReadLine()
                                   .Split(" ")                                   
                                   .ToList();
            while (command[0] != "end")
            {
                string realCommand = command[0];
                int number = int.Parse(command[1]);


                if (realCommand == "Add")
                {
                    numbers.Add(number);
                }

                else if (realCommand == "Remove")
                {
                    numbers.Remove(number);
                }

                else if (realCommand == "RemoveAt")
                {
                    // !!NB!! ** INDEX == number ** !!NB!!
                    numbers.RemoveAt(number); 
                }

                else if (command.Count == 3)
                {
                    int index = int.Parse(command[2]);

                    if (realCommand == "Insert")
                    {
                        numbers.Insert(index, number);
                    }
                }

                command = Console.ReadLine()
                          .Split()
                          .ToList();

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
