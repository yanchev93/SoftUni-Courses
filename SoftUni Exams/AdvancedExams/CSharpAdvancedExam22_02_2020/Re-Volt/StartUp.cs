using System;

namespace Re_Volt
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int commandsInput = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int[] playerPosition = ReadMatrix(matrix);

            int playerRow = playerPosition[0];
            int playerCol = playerPosition[1];

            bool playerWon = false;

            for (int rows = 0; rows < commandsInput; rows++)
            {
                if (playerWon)
                {
                    break;
                }

                for (int cols = 0; cols < 1; cols++)
                {
                    string command = Console.ReadLine();

                    bool isItBonus = false;
                    bool isItOut = false;

                    if (command == "up")
                    {
                        int tempPlayerRowOut = playerRow;
                        int tempPlayerRowBonus = playerRow;
                        int tempPlayerRow = playerRow;

                        if (playerRow - 1 < 0)
                        {
                            isItOut = true;
                            playerRow = matrix.GetLength(0) - 1;
                        }
                        else
                        {
                            playerRow -= 1;
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            if (isItOut)
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow += 1;
                            }

                            break;
                        }

                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            isItBonus = true;

                            if (playerRow - 1 < 0)
                            {
                                isItOut = true;
                                playerRow = matrix.GetLength(0) - 1;
                            }
                            else
                            {
                                playerRow -= 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            playerWon = true;
                        }

                        if (isItBonus)
                        {
                            matrix[tempPlayerRowBonus, playerCol] = '-';
                        }

                        else if (isItOut)
                        {
                            matrix[tempPlayerRowOut, playerCol] = '-';
                        }

                        else
                        {
                            matrix[tempPlayerRow, playerCol] = '-';
                        }

                        matrix[playerRow, playerCol] = 'f';
                    }

                    if (command == "down")
                    {
                        int tempPlayerRowOut = playerRow;
                        int tempPlayerRowBonus = playerRow;
                        int tempPlayerRow = playerRow;

                        if (playerRow + 1 >= matrix.GetLength(0))
                        {
                            isItOut = true;
                            playerRow = 0;
                        }
                        else
                        {
                            playerRow += 1;
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            if (isItOut)
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow -= 1;
                            }

                            break;
                        }

                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            isItBonus = true;

                            if (playerRow + 1 >= matrix.GetLength(0))
                            {
                                isItOut = true;
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow += 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            playerWon = true;
                        }

                        if (isItBonus)
                        {
                            matrix[tempPlayerRowBonus, playerCol] = '-';
                        }

                        else if (isItOut)
                        {
                            matrix[tempPlayerRowOut, playerCol] = '-';
                        }

                        else
                        {
                            matrix[tempPlayerRow, playerCol] = '-';
                        }

                        matrix[playerRow, playerCol] = 'f';
                    }

                    if (command == "left")
                    {
                        int tempPlayerColOut = playerCol;
                        int tempPlayerColBonus = playerCol;
                        int tempPlayerCol = playerCol;

                        if (playerCol - 1 < 0)
                        {
                            isItOut = true;
                            playerCol = matrix.GetLength(1) - 1;
                        }
                        else
                        {
                            playerCol -= 1;
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            if (isItOut)
                            {
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol += 1;
                            }

                            break;
                        }

                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            isItBonus = true;

                            if (playerCol - 1 < 0)
                            {
                                isItOut = true;
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            else
                            {
                                playerCol -= 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            playerWon = true;
                        }

                        if (isItBonus)
                        {
                            matrix[playerRow, tempPlayerColBonus] = '-';
                        }

                        else if (isItOut)
                        {
                            matrix[playerRow, tempPlayerColOut] = '-';
                        }

                        else
                        {
                            matrix[playerRow, tempPlayerCol] = '-';
                        }

                        matrix[playerRow, playerCol] = 'f';
                    }

                    if (command == "right")
                    {
                        int tempPlayerColOut = playerCol;
                        int tempPlayerColBonus = playerCol;
                        int tempPlayerCol = playerCol;

                        if (playerCol + 1 >= matrix.GetLength(1))
                        {
                            isItOut = true;
                            playerCol = 0;
                        }
                        else
                        {
                            playerCol += 1;
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            if (isItOut)
                            {
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            else
                            {
                                playerCol -= 1;
                            }

                            break;
                        }

                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            isItBonus = true;

                            if (playerCol + 1 >= matrix.GetLength(1))
                            {
                                isItOut = true;
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol += 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            playerWon = true;
                        }

                        if (isItBonus)
                        {
                            matrix[playerRow, tempPlayerColBonus] = '-';
                        }

                        else if (isItOut)
                        {
                            matrix[playerRow, tempPlayerColOut] = '-';
                        }

                        else
                        {
                            matrix[playerRow, tempPlayerCol] = '-';
                        }

                        matrix[playerRow, playerCol] = 'f';
                    }
                }
            }

            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static int[] ReadMatrix(char[,] matrix)
        {
            int[] playerPosition = new int[2];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] inputMatrix = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = inputMatrix[cols];

                    if (inputMatrix[cols] == 'f')
                    {
                        playerPosition[0] = rows;
                        playerPosition[1] = cols;
                    }
                }
            }

            return playerPosition;
        }
    }
}
