using System;
using System.Linq;

namespace _03._PrimaryDiagonal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsAndCols, rowsAndCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputCols = Console.ReadLine().Split(' ',
                                  StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputCols[col];
                }
            }

            int sum = matrix[0, 0];
            int index = 1;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = index; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                    index += 1;
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
