using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] inputMatrix = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = inputMatrix[0];
            int cols = inputMatrix[1];


            int[,] matrix = new int[rows, cols];
            CreatMatrix(matrix);

            int matrixRowType = 2;
            int matrixColType = 2;

            int count = 0;
            for (int row = 0; row <= matrix.GetLength(0) - matrixRowType; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - matrixColType; col++)
                {
                    bool squareMatrixSame =
                        matrix[row + 0, col + 0] == matrix[row + 0, col + 1] &&
                        matrix[row + 0, col + 0] == matrix[row + 1, col + 0] &&
                        matrix[row + 1, col + 0] == matrix[row + 1, col + 1];
                                            
                    if (squareMatrixSame)
                    {
                        count += 1;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void CreatMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputMatrix = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }
            }
        }
    }
}
