namespace Garden
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] inputMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = inputMatrix[0];
            int m = inputMatrix[1];

            int[,] matrix = new int[n, m];

            string command;
            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] rowsAndCols = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = rowsAndCols[0];
                int col = rowsAndCols[1];


                if (n <= row || m <= col
                    || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates.");

                    continue;
                }

                for (int rows = col; rows < matrix.GetLength(1); rows++)
                {
                    matrix[row, rows] += 1;
                }

                for (int cols = row - 1; cols >= 0; cols--)
                {
                    matrix[cols, col] += 1;
                }

                for (int rows = row + 1; rows < matrix.GetLength(0); rows++)
                {
                    matrix[rows, col] += 1;
                }

                for (int cols = col - 1; cols >= 0; cols--)
                {
                    matrix[row, cols] += 1;
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
