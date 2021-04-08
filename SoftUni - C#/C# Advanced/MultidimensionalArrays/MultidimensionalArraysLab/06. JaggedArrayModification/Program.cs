using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[n][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int[] inputJagged = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[i] = new int[inputJagged.Length];
                jaggedArr[i] = inputJagged;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = currentCommand[0];
                int row = int.Parse(currentCommand[1]);
                int col = int.Parse(currentCommand[2]);
                int value = int.Parse(currentCommand[3]);

                bool isInRange = ((0 <= row && row < jaggedArr.Length) &&
                                 (0 <= col && col < jaggedArr[row].Length));
                if (!isInRange)
                {
                    Console.WriteLine("Invalid coordinates");

                    command = Console.ReadLine();
                    continue;
                }

                else if (instruction == "Add")
                {
                    jaggedArr[row][col] += value;
                }

                else if (instruction == "Subtract")
                {
                    jaggedArr[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            foreach (int[] arr in jaggedArr)
            {
                Console.WriteLine(string.Join(' ', arr));
            }
        }
    }
}
