using System;
using System.Linq;

namespace _04._MatrixShuffling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            string[,] matrix = new string[rows, cols];

            CreateMatrix(matrix);

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                if (!(command.StartsWith("swap") && currentCommand.Length == 5))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int oldRow = int.Parse(currentCommand[1]);
                int oldCol = int.Parse(currentCommand[2]);
                int newRow = int.Parse(currentCommand[3]);
                int newCol = int.Parse(currentCommand[4]);

                bool oldIsInRange = (0 <= oldRow && oldRow < matrix.GetLength(0)) &&
                                 (0 <= oldCol && oldCol < matrix.GetLength(1));
                bool newIsInRange = (0 <= newRow && newRow < matrix.GetLength(0)) &&
                                    (0 <= newCol && newCol < matrix.GetLength(1));

                if (oldIsInRange && newIsInRange)
                {
                    string changeOld = matrix[oldRow, oldCol];
                    string changeNew = matrix[newRow, newCol];

                    matrix[oldRow, oldCol] = changeNew;
                    matrix[newRow, newCol] = changeOld;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + ' ');
                }
                Console.WriteLine();
            }
        }

        private static void CreateMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] inputMatrix = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }
            }
        }
    }
}
