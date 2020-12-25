using System;
using System.Linq;

namespace _09._Miner
{
    class StartUo
    {
        static int coal;
        static int playerRow;
        static int playerCol;

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);
            string[,] mine = new string[size, size];

            InitializeMatrix(mine);

            int currentPlayerRow = playerRow;
            int currentPlayerCol = playerCol;

            foreach (var direction in directions)
            {
                if (direction == "up")
                {
                    MoveUp(mine, playerRow, playerCol);
                }

                else if (direction == "down")
                {
                    MoveDown(mine, playerRow, playerCol);
                }

                else if (direction == "right")
                {
                    MoveRight(mine, playerRow, playerCol);
                }

                else if (direction == "left")
                {
                    MoveLeft(mine, playerRow, playerCol);
                }

            }

            Console.WriteLine($"{coal} coals left. ({playerRow}, {playerCol})");

        }

        private static void MoveUp(string[,] mine, int currentRow, int currentCol)
        {
            if (IsInRange(mine, currentRow - 1, currentCol + 0))
            {

                if (mine[currentRow - 1, currentCol + 0] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow - 1}, {currentCol + 0})");
                    Environment.Exit(0);
                }

                else if (mine[currentRow - 1, currentCol + 0] == "*")
                {
                    mine[currentRow + 0, currentCol + 0] = "*"; // player old spot
                    mine[currentRow - 1, currentCol + 0] = "s"; // player new spot

                    playerRow = currentRow - 1;
                    playerCol = currentCol + 0;
                }

                else if (mine[currentRow - 1, currentCol + 0] == "c")
                {
                    coal -= 1;
                    mine[currentRow + 0, currentCol + 0] = "*"; // player old spot
                    mine[currentRow - 1, currentCol + 0] = "s"; // player new spot

                    playerRow = currentRow - 1;
                    playerCol = currentCol + 0;
                }

                if (coal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow - 1}, {currentCol + 0})");
                    Environment.Exit(0);
                }
            }
        }

        private static void MoveDown(string[,] mine, int currentRow, int currentCol)
        {
            if (IsInRange(mine, currentRow + 1, currentCol + 0))
            {

                if (mine[currentRow + 1, currentCol + 0] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow + 1}, {currentCol + 0})");
                    Environment.Exit(0);
                }

                else if (mine[currentRow + 1, currentCol + 0] == "*")
                {
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 1, currentCol + 0] = "s";

                    playerRow = currentRow + 1;
                    playerCol = currentCol + 0;
                }

                else if (mine[currentRow + 1, currentCol + 0] == "c")
                {
                    coal -= 1;
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 1, currentCol + 0] = "s";

                    playerRow = currentRow + 1;
                    playerCol = currentCol + 0;
                }

                if (coal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow + 1}, {currentCol + 0})");
                    Environment.Exit(0);
                }
            }
        }

        private static void MoveRight(string[,] mine, int currentRow, int currentCol)
        {
            if (IsInRange(mine, currentRow + 0, currentCol + 1))
            {

                if (mine[currentRow + 0, currentCol + 1] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow + 0}, {currentCol + 1})");
                    Environment.Exit(0);
                }

                else if (mine[currentRow + 0, currentCol + 1] == "*")
                {
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 0, currentCol + 1] = "s";

                    playerRow = currentRow + 0;
                    playerCol = currentCol + 1;
                }

                else if (mine[currentRow + 0, currentCol + 1] == "c")
                {
                    coal -= 1;
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 0, currentCol + 1] = "s";

                    playerRow = currentRow + 0;
                    playerCol = currentCol + 1;
                }

                if (coal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow + 0}, {currentCol + 1})");
                    Environment.Exit(0);
                }
            }
        }

        private static void MoveLeft(string[,] mine, int currentRow, int currentCol)
        {
            if (IsInRange(mine, currentRow + 0, currentCol - 1))
            {

                if (mine[currentRow + 0, currentCol - 1] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow + 0}, {currentCol - 1})");
                    Environment.Exit(0);
                }

                else if (mine[currentRow + 0, currentCol - 1] == "*")
                {
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 0, currentCol - 1] = "s";

                    playerRow = currentRow + 0;
                    playerCol = currentCol - 1;
                }

                else if (mine[currentRow + 0, currentCol - 1] == "c")
                {
                    coal -= 1;
                    mine[currentRow + 0, currentCol + 0] = "*";
                    mine[currentRow + 0, currentCol - 1] = "s";

                    playerRow = currentRow + 0;
                    playerCol = currentCol - 1;
                }

                if (coal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow + 0}, {currentCol - 1})");
                    Environment.Exit(0);
                }
            }
        }

        private static bool IsInRange(string[,] mine, int playerRow, int playerCol)
        {
            bool isInRange = false;

            if (0 <= playerRow && playerRow < mine.GetLength(0) &&
                0 <= playerCol && playerCol < mine.GetLength(1))
            {
                isInRange = true;
            }

            return isInRange;
        }

        private static void InitializeMatrix(string[,] mine)
        {
            for (int row = 0; row < mine.GetLength(0); row++)
            {
                string[] inputRow = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < mine.GetLength(1); col++)
                {
                    if (inputRow[col] == "c")
                    {
                        coal += 1;
                    }

                    if (inputRow[col] == "s")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    mine[row, col] = inputRow[col];
                }
            }
        }
    }
}
