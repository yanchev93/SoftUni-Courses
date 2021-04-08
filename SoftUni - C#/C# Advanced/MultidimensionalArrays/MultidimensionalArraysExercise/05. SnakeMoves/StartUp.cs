using System;
using System.Linq;

namespace _05._SnakeMoves
{
    class StartUp
    {
        static void Main()
        {
            int[] matrixDimension = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixDimension[0];
            int cols = matrixDimension[1];
            char[,] matrix = new char[rows, cols];

            string input = Console.ReadLine();

            int count = 0;
            int startIndexRow = 0;
            int countBreak = 0;


            for (int row = startIndexRow; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (input.Length == count)
                    {
                        count = 0;
                    }

                    matrix[row, col] = input[count];
                    count += 1;
                }

                row = startIndexRow + 1;

                if (countBreak == (matrix.GetLength(0) / 2))
                {
                    break;
                }

                for (int reversedCol = matrix.GetLength(1) - 1; reversedCol >= 0; reversedCol--)
                {
                    if (input.Length == count)
                    {
                        count = 0;
                    }

                    matrix[row, reversedCol] = input[count];
                    count += 1;
                }

                startIndexRow = row + 1;
                countBreak += 1;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

