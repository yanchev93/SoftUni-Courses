using System;
using System.Linq;

namespace _06._JaggedArrayManipulator
{
    class StartUp
    {
        static void Main()
        {
            int numberRows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[numberRows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                double[] array = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = array;
            }

            for (int row = 1; row < jaggedArray.Length; row++)
            {
                if (jaggedArray[row - 1].Length == jaggedArray[row].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row - 1][col] *= 2;
                        jaggedArray[row][col] *= 2;
                    }
                }

                else
                {
                    for (int col = 0; col < jaggedArray[row - 1].Length; col++)
                    {
                        if (jaggedArray[row - 1][col] == 0)
                        {
                            continue;
                        }

                        jaggedArray[row - 1][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        if (jaggedArray[row][col] == 0)
                        {
                            continue;
                        }

                        jaggedArray[row][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string instruction = currentCommand[0];
                int row = int.Parse(currentCommand[1]);
                int col = int.Parse(currentCommand[2]);
                double value = double.Parse(currentCommand[3]);

                if (row < 0 || jaggedArray.Length <= row || col < 0 || jaggedArray[row].Length <= col)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (instruction == "Add")
                {
                    jaggedArray[row][col] += value;

                }

                else if (instruction == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            foreach (var array in jaggedArray)
            {
                double[] currentArray = array;
                Console.WriteLine(string.Join(' ', currentArray));
            }
        }
    }
}
