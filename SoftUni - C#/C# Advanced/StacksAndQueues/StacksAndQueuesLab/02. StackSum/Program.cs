using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> arrNums = new Stack<int>(Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            string command = Console.ReadLine();
            while (command.ToUpper() != "END")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = currentCommand[0].ToUpper();
                if (instruction == "ADD")
                {
                    int firstNum = int.Parse(currentCommand[1]);
                    int secondNum = int.Parse(currentCommand[2]);

                    arrNums.Push(firstNum);
                    arrNums.Push(secondNum);
                }

                else if (instruction == "REMOVE")
                {
                    int remove = int.Parse(currentCommand[1]);

                    if (remove <= arrNums.Count)
                    {
                        for (int i = 0; i < remove; i++)
                        {
                            arrNums.Pop();
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {arrNums.Sum()}");
        }
    }
}
