namespace P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            string[] coordinates = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;

            for (int rows = 0; rows < n; rows++)
            {
                char[] input = Console.ReadLine()
                               .Split(' ')
                               .Select(char.Parse)
                               .ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    if (input[cols] == '<')
                    {
                        firstPlayerShips += 1;
                    }
                    else if (input[cols] == '>')
                    {
                        secondPlayerShips += 1;
                    }

                    matrix[rows, cols] = input[cols];
                }
            }

            int totalShipsStart = firstPlayerShips + secondPlayerShips;

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentCoordinate = coordinates[i].
                    Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = currentCoordinate[0];
                int col = currentCoordinate[1];


                if (row < 0 || matrix.GetLength(0) <= row)
                {
                    continue;
                }

                if (col < 0 || matrix.GetLength(1) <= col)
                {
                    continue;
                }

                if (matrix[row, col] == '<')
                {
                    matrix[row, col] = 'X';
                    firstPlayerShips -= 1;
                }
                else if (matrix[row, col] == '>')
                {
                    matrix[row, col] = 'X';
                    secondPlayerShips -= 1;
                }
                else if (matrix[row, col] == '#')
                {
                    matrix[row, col] = 'X';

                    if (0 <= row - 1)
                    {
                        if (matrix[row - 1, col] == '<')
                        {
                            matrix[row - 1, col] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row - 1, col] == '>')
                        {
                            matrix[row - 1, col] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1, col] == '<')
                        {
                            matrix[row + 1, col] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row + 1, col] == '>')
                        {
                            matrix[row + 1, col] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (0 <= col - 1)
                    {
                        if (matrix[row, col - 1] == '<')
                        {
                            matrix[row, col - 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row, col - 1] == '>')
                        {
                            matrix[row, col - 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col + 1] == '<')
                        {
                            matrix[row, col + 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row, col + 1] == '>')
                        {
                            matrix[row, col + 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (0 <= row - 1 && 0 <= col - 1)
                    {
                        if (matrix[row - 1, col - 1] == '<')
                        {
                            matrix[row - 1, col - 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row - 1, col - 1] == '>')
                        {
                            matrix[row - 1, col - 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (0 <= row - 1 && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row - 1, col + 1] == '<')
                        {
                            matrix[row - 1, col + 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row - 1, col + 1] == '>')
                        {
                            matrix[row - 1, col + 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (row + 1 < matrix.GetLength(0) && 0 <= col - 1)
                    {
                        if (matrix[row + 1, col - 1] == '<')
                        {
                            matrix[row + 1, col - 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row + 1, col - 1] == '>')
                        {
                            matrix[row + 1, col - 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row + 1, col + 1] == '<')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            firstPlayerShips -= 1;
                        }
                        else if (matrix[row + 1, col + 1] == '>')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            secondPlayerShips -= 1;
                        }
                    }
                }

                PrintMatrix(matrix);

                Console.WriteLine();

                if (firstPlayerShips == 0)
                {
                    int totalCountShipsDestroyed = totalShipsStart - secondPlayerShips;

                    Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");

                    return;
                    //secondWins = true;
                    //break;
                }
                else if (secondPlayerShips == 0)
                {
                    int totalCountShipsDestroyed = totalShipsStart - firstPlayerShips;

                    Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");

                    return;
                    //firstWins = true;
                    //break;
                }
            }

            Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");

            // foreach (var coordinate in coordinates)
            // {
            //     int[] currentCoordinate = coordinate.
            //         Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //         .Select(int.Parse)
            //         .ToArray();
            //     int row = currentCoordinate[0];
            //     int col = currentCoordinate[1];
            // 
            // }

            // if (firstWins)
            // {
            //     int totalCountShipsDestroyed = totalShipsStart - firstPlayerShips;
            // 
            //     Console.WriteLine($"Player One has won the game!  {totalCountShipsDestroyed} //ships have been sunk in the battle.");
            // }
            // else if (secondWins)
            // {
            //     int totalCountShipsDestroyed = totalShipsStart - secondPlayerShips;
            // 
            //     Console.WriteLine($"Player Two has won the game!  {totalCountShipsDestroyed} //ships have been sunk in the battle.");
            // }
            // else
            // {
            //     
            // }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
