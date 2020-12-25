using System;
using System.Linq;

namespace _03._MaximalSum
{
    class StartUp
    {
        static void Main()
        {
            int[] rNc = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rNc[0];
            int cols = rNc[1];
            int[,] matrix = new int[rows, cols];

            CreateMatrix(matrix);

            int maxSum = 0;
            int maxSumRow = 0;
            int maxSumCol = 0;

            int rowMatrix3x3 = 3;
            int colMatrix3x3 = 3;

            for (int row = 0; row <= matrix.GetLength(0) - rowMatrix3x3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - colMatrix3x3; col++)
                {
                    int maxSum3x3 =
                    matrix[row + 0, col + 0] + matrix[row + 0, col + 1] + matrix[row + 0, col + 2] +
                    matrix[row + 1, col + 0] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col + 0] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maxSum < maxSum3x3)
                    {
                        maxSum = maxSum3x3;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxSumRow + 0, maxSumCol + 0]} {matrix[maxSumRow + 0, maxSumCol + 1]} {matrix[maxSumRow + 0, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol + 0]} {matrix[maxSumRow + 1, maxSumCol + 1]} {matrix[maxSumRow + 1, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 2, maxSumCol + 0]} {matrix[maxSumRow + 2, maxSumCol + 1]} {matrix[maxSumRow + 2, maxSumCol + 2]}");
        }

        private static void CreateMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputMatrix = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }
            }
        }

    }
}
