using System;
using System.Linq;

namespace MultidamensionalArrays
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
                int[] columns = Console.ReadLine().Split(", ",
                               StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }

            int sum = 0;
            foreach (var num in matrix)
            {
                sum += num;
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
