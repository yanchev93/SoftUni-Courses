using System;
using System.Linq;

namespace _08._Bombs
{
    class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] bombBoard = new int[size, size];
            InitializeMatrix(bombBoard);

            string[] bombs = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);


            foreach (string bomb in bombs)
            {
                string[] currentBomb = bomb.Split(',',
                    StringSplitOptions.RemoveEmptyEntries);
                int rowBomb = int.Parse(currentBomb[0]);
                int colBomb = int.Parse(currentBomb[1]);

                ExplodeBomb(bombBoard, rowBomb, colBomb);

            }



            int sum = 0;
            int aliveCells = 0;

            foreach (var number in bombBoard)
            {
                if (number > 0)
                {
                    sum += number;
                    aliveCells += 1;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(bombBoard);
        }

        private static void ExplodeBomb(int[,] bombBoard, int rowBomb, int colBomb)
        {
            int bombPower = bombBoard[rowBomb, colBomb];

            if (bombPower > 0)
            {
                // upper row
                if (IsInRange(bombBoard, rowBomb - 1, colBomb - 1))
                {
                    int upLeft = bombBoard[rowBomb - 1, colBomb - 1];
                    if (upLeft > 0)
                    {
                        upLeft -= bombPower;
                        bombBoard[rowBomb - 1, colBomb - 1] = upLeft;
                    }
                }

                if (IsInRange(bombBoard, rowBomb - 1, colBomb + 0))
                {
                    int upCenter = bombBoard[rowBomb - 1, colBomb + 0];
                    if (upCenter > 0)
                    {
                        upCenter -= bombPower;
                        bombBoard[rowBomb - 1, colBomb + 0] = upCenter;
                    }
                }

                if (IsInRange(bombBoard, rowBomb - 1, colBomb + 1))
                {
                    int upRight = bombBoard[rowBomb - 1, colBomb + 1];
                    if (upRight > 0)
                    {
                        upRight -= bombPower;
                        bombBoard[rowBomb - 1, colBomb + 1] = upRight;
                    }
                }

                /* upperRow -> represented as simple as it can be
                bombBoard[rowBomb - 1, colBomb + 1] -= bombPower;
                bombBoard[rowBomb - 1, colBomb - 1] -= bombPower;
                bombBoard[rowBomb - 1, colBomb + 0] -= bombPower;
                */

                //current row
                if (IsInRange(bombBoard, rowBomb + 0, colBomb - 1))
                {
                    int currentLeft = bombBoard[rowBomb + 0, colBomb - 1];
                    if (currentLeft > 0)
                    {
                        currentLeft -= bombPower;
                        bombBoard[rowBomb + 0, colBomb - 1] = currentLeft;
                    }
                }

                if (IsInRange(bombBoard, rowBomb + 0, colBomb + 0))
                {
                    int currentCenter = bombBoard[rowBomb + 0, colBomb + 0];
                    if (currentCenter > 0)
                    {
                        currentCenter -= bombPower;
                        bombBoard[rowBomb + 0, colBomb + 0] = currentCenter;
                    }
                }

                if (IsInRange(bombBoard, rowBomb + 0, colBomb + 1))
                {
                    int currentRight = bombBoard[rowBomb + 0, colBomb + 1];
                    if (currentRight > 0)
                    {
                        currentRight -= bombPower;
                        bombBoard[rowBomb + 0, colBomb + 1] = currentRight;
                    }
                }

                /* currentRow -> represented as simple as it can be
                bombBoard[rowBomb + 0, colBomb - 1] -= bombPower;
                bombBoard[rowBomb + 0, colBomb + 0] -= bombPower;
                bombBoard[rowBomb + 0, colBomb + 1] -= bombPower;
                */

                //down row
                if (IsInRange(bombBoard, rowBomb + 1, colBomb - 1))
                {
                    int downLeft = bombBoard[rowBomb + 1, colBomb - 1];
                    if (downLeft > 0)
                    {
                        downLeft -= bombPower;
                        bombBoard[rowBomb + 1, colBomb - 1] = downLeft;
                    }
                }

                if (IsInRange(bombBoard, rowBomb + 1, colBomb + 0))
                {
                    int downCenter = bombBoard[rowBomb + 1, colBomb + 0];
                    if (downCenter > 0)
                    {
                        downCenter -= bombPower;
                        bombBoard[rowBomb + 1, colBomb + 0] = downCenter;
                    }
                }

                if (IsInRange(bombBoard, rowBomb + 1, colBomb + 1))
                {
                    int downRight = bombBoard[rowBomb + 1, colBomb + 1];
                    if (downRight > 0)
                    {
                        downRight -= bombPower;
                        bombBoard[rowBomb + 1, colBomb + 1] = downRight;
                    }
                }

                /* downRow -> represented as simple as it can be
                bombBoard[rowBomb + 1, colBomb - 1] -= bombPower;
                bombBoard[rowBomb + 1, colBomb + 0] -= bombPower;
                bombBoard[rowBomb + 1, colBomb + 1] -= bombPower;
                */

                bombBoard[rowBomb, colBomb] = 0;
            }
        }

        private static bool IsInRange(int[,] bombBoard, int rowBomb, int colBomb)
        {
            bool isInRange = true;
            if (!(0 <= rowBomb && rowBomb < bombBoard.GetLength(0) &&
                0 <= colBomb && colBomb < bombBoard.GetLength(1)))
            {
                isInRange = false;
            }

            return isInRange;
        }

        private static void PrintMatrix(int[,] bombBoard)
        {
            for (int row = 0; row < bombBoard.GetLength(0); row++)
            {
                for (int col = 0; col < bombBoard.GetLength(1); col++)
                {
                    Console.Write($"{bombBoard[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void InitializeMatrix(int[,] bombBoard)
        {
            for (int row = 0; row < bombBoard.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < bombBoard.GetLength(1); col++)
                {
                    bombBoard[row, col] = inputRow[col];
                }
            }
        }
    }
}
