using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class ListOperations
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<string> command = Console.ReadLine()
                                   .Split()
                                   .ToList();
            
            while (command[0] != "End")
            {
                string input = command[0];
                

                if (input == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                    command = Console.ReadLine()
                                   .Split()
                                   .ToList();
                    continue;
                }

                else if (input == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index < 0 || (numbers.Count - 1) < index)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.Insert(index, number);
                    }

                    command = Console.ReadLine()
                                   .Split()
                                   .ToList();
                    continue;
                }

                else if (input == "Remove")
                {
                    // "NB" !! Here number represents the index !! "NB" 
                    
                    int number = int.Parse(command[1]);

                    if (number < 0 || (numbers.Count - 1) < number)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.RemoveAt(number);
                    }

                    command = Console.ReadLine()
                                       .Split()
                                       .ToList();
                    continue;
                }

                else if (input == "Shift")
                {
                    string inputTwo = command[1];
                    int count = int.Parse(command[2]);
                    if (inputTwo == "left")
                    {
                        
                        for (int i = 1; i <= count; i++)
                        {
                            int numSwitch = numbers[0];
                            numbers.Insert(0, numbers[1]);
                            numbers.RemoveAt(1);
                            numbers.RemoveAt(1);
                            numbers.Add(numSwitch);
                        }
                        
                    }

                    else
                    {
                        int numSwitch = 0;
                        for (int i = 0; i < count; i++)
                        {
                            numSwitch = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, numSwitch);
                        }                        
                    }

                    command = Console.ReadLine()
                                   .Split()
                                   .ToList();                                        
                    continue;
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
