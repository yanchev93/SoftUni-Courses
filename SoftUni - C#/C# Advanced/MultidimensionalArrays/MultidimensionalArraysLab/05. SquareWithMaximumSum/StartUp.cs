using System;
using System.Linq;

namespace _05._SquareWithMaximumSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(", ",
                              StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int subRow = 2;
            int subCol = 2;

            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            int[,] subMatrix = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0) - subRow + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subCol + 1; col++)
                {
                    int sum = matrix[row + 0, col + 0] + matrix[row + 0, col + 1] +
                              matrix[row + 1, col + 0] + matrix[row + 1, col + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow + 0, maxCol + 0]} {matrix[maxRow + 0, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol + 0]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
