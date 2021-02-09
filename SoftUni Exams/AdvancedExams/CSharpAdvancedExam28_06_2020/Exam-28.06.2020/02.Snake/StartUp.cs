namespace _02.Snake
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int snakeRow = 0;
            int snakeCol = 0;
            int foodQty = 0;
            int foodToBeEaten = 0;

            bool isFirstBurrowFoundNotFound = true;
            int firstBurrowRow = 0;
            int firstBurrowCol = 0;

            bool isSecondBurrowFoundNotFound = true;
            int secondBurrowRow = 0;
            int secondBurrowCol = 0;

            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            ReadMatrix(ref snakeRow, ref snakeCol, ref isFirstBurrowFoundNotFound, ref firstBurrowRow, ref firstBurrowCol, ref isSecondBurrowFoundNotFound, ref secondBurrowRow, ref secondBurrowCol, n, matrix, ref foodToBeEaten);

            
            bool isOutside = false;


            while (true)
            {
                string command = Console.ReadLine();

                matrix[snakeRow, snakeCol] = '.';

                if (command == "up")
                {
                    snakeRow -= 1;

                    if (snakeRow < 0)
                    {
                        isOutside = true;
                        break;
                    }
                    else if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        FirstBurrow(ref snakeRow, ref snakeCol, secondBurrowRow, secondBurrowCol, matrix);
                    }
                    else if (snakeRow == secondBurrowRow && snakeCol == secondBurrowCol)
                    {
                        SecondBurrow(ref snakeRow, ref snakeCol, firstBurrowRow, firstBurrowCol, matrix);
                    }
                    else if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodToBeEaten -= 1;
                        foodQty += 1;

                        matrix[snakeRow, snakeCol] = 'S';
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = 'S';
                    }
                }
                else if (command == "down")
                {
                    snakeRow += 1;

                    if (matrix.GetLength(0) <= snakeRow)
                    {
                        isOutside = true;
                        break;
                    }
                    else if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        FirstBurrow(ref snakeRow, ref snakeCol, secondBurrowRow, secondBurrowCol, matrix);
                    }
                    else if (snakeRow == secondBurrowRow && snakeCol == secondBurrowCol)
                    {
                        SecondBurrow(ref snakeRow, ref snakeCol, firstBurrowRow, firstBurrowCol, matrix);
                    }
                    else if (matrix[snakeRow,snakeCol] == '*')
                    {
                        foodToBeEaten -= 1;
                        foodQty += 1;

                        matrix[snakeRow, snakeCol] = 'S';
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = 'S';
                    }
                }
                else if (command == "left")
                {
                    snakeCol -= 1;

                    if (snakeCol < 0)
                    {
                        isOutside = true;
                        break;
                    }
                    else if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        FirstBurrow(ref snakeRow, ref snakeCol, secondBurrowRow, secondBurrowCol, matrix);
                    }
                    else if (snakeRow == secondBurrowRow && snakeCol == secondBurrowCol)
                    {
                        SecondBurrow(ref snakeRow, ref snakeCol, firstBurrowRow, firstBurrowCol, matrix);
                    }
                    else if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodToBeEaten -= 1;
                        foodQty += 1;

                        matrix[snakeRow, snakeCol] = 'S';
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = 'S';
                    }
                }
                else if (command == "right")
                {
                    snakeCol += 1;

                    if (matrix.GetLength(1) <= snakeRow)
                    {
                        isOutside = true;
                        break;
                    }
                    else if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        FirstBurrow(ref snakeRow, ref snakeCol, secondBurrowRow, secondBurrowCol, matrix);
                    }
                    else if (snakeRow == secondBurrowRow && snakeCol == secondBurrowCol)
                    {
                        SecondBurrow(ref snakeRow, ref snakeCol, firstBurrowRow, firstBurrowCol, matrix);
                    }
                    else if (matrix[snakeRow,snakeCol] == '*')
                    {
                        foodToBeEaten -= 1;
                        foodQty += 1;

                        matrix[snakeRow, snakeCol] = 'S';
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = 'S';
                    }
                }

                if (foodQty >= 10)
                {
                    break;
                }
            }

            if (isOutside || foodQty < 10)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {foodQty}");

            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
                Console.WriteLine($"Food eaten: 10");
            }

            PrintMatrix(matrix);
        }

        private static void SecondBurrow(ref int snakeRow, ref int snakeCol, int firstBurrowRow, int firstBurrowCol, char[,] matrix)
        {
            matrix[snakeRow, snakeCol] = '.';

            snakeRow = firstBurrowRow;
            snakeCol = firstBurrowCol;

            matrix[snakeRow, snakeCol] = 'S';
        }

        private static void FirstBurrow(ref int snakeRow, ref int snakeCol, int secondBurrowRow, int secondBurrowCol, char[,] matrix)
        {
            matrix[snakeRow, snakeCol] = '.';

            snakeRow = secondBurrowRow;
            snakeCol = secondBurrowCol;

            matrix[snakeRow, snakeCol] = 'S';
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

        private static void ReadMatrix(ref int snakeRow, ref int snakeCol, ref bool isFirstBurrowFoundNotFound, ref int firstBurrowRow, ref int firstBurrowCol, ref bool isSecondBurrowFoundNotFound, ref int secondBurrowRow, ref int secondBurrowCol, int n, char[,] matrix, ref int foodToBeEaten)
        {
            for (int rows = 0; rows < n; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int cols = 0; cols < n; cols++)
                {
                    if (input[cols] == 'S')
                    {
                        snakeRow = rows;
                        snakeCol = cols;
                    }
                    else if (input[cols] == 'B' && isFirstBurrowFoundNotFound)
                    {
                        isFirstBurrowFoundNotFound = false;

                        firstBurrowRow = rows;
                        firstBurrowCol = cols;
                    }
                    else if (input[cols] == 'B' && isSecondBurrowFoundNotFound)
                    {
                        isSecondBurrowFoundNotFound = false;

                        secondBurrowRow = rows;
                        secondBurrowCol = cols;
                    }
                    else if (input[cols] == '*')
                    {
                        foodToBeEaten += 1;
                    }

                    matrix[rows, cols] = input[cols];
                }
            }
        }
    }
}
