using System;
using System.Linq;

namespace MultidimensionalArraysExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col]; 
                }
            }

            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int leftRow = matrix[row, row];
                sumLeftDiagonal += leftRow;

                int rightRow = matrix[row, n - row - 1];
                sumRightDiagonal += rightRow;
            }

            Console.WriteLine(Math.Abs(sumLeftDiagonal - sumRightDiagonal));
        }
    }
}
