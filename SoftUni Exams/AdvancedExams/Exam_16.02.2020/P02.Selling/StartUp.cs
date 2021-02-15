namespace P02.Selling
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int playerRow = 0;
            int playerCol = 0;

            int firstPillarRow = 0;
            int firstPillarCol = 0;
            int secondPillarRow = 0;
            int secondPillarCol = 0;
            bool isFirstPillarFound = false;

            char[,] matrix = new char[n, n];
            ReadMatrix(n, ref playerRow, ref playerCol, ref firstPillarRow, ref firstPillarCol, ref secondPillarRow, ref secondPillarCol, ref isFirstPillarFound, matrix);


            int money = 0;
            bool isItOut = false;
            while (true)
            {
                string command = Console.ReadLine();

                matrix[playerRow, playerCol] = '-';

                if (command == "up")
                {
                    playerRow -= 1;

                    if (playerRow < 0)
                    {
                        isItOut = true;
                        break;
                    }
                    if (matrix[playerRow, playerCol] == 'O')
                    {
                        PillarMove(ref playerRow, ref playerCol, firstPillarRow, firstPillarCol, secondPillarRow, secondPillarCol, matrix);
                    }
                    else if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        char clientMoney = matrix[playerRow, playerCol];
                        money += int.Parse(clientMoney.ToString());
                    }
                }
                else if (command == "down")
                {
                    playerRow += 1;

                    if (matrix.GetLength(0) <= playerRow)
                    {
                        isItOut = true;
                        break;
                    }
                    if (matrix[playerRow, playerCol] == 'O')
                    {
                        PillarMove(ref playerRow, ref playerCol, firstPillarRow, firstPillarCol, secondPillarRow, secondPillarCol, matrix);
                    }
                    else if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        char clientMoney = matrix[playerRow, playerCol];
                        money += int.Parse(clientMoney.ToString());
                    }
                }
                else if (command == "left")
                {
                    playerCol -= 1;

                    if (playerCol < 0)
                    {
                        isItOut = true;
                        break;
                    }
                    if (matrix[playerRow, playerCol] == 'O')
                    {
                        PillarMove(ref playerRow, ref playerCol, firstPillarRow, firstPillarCol, secondPillarRow, secondPillarCol, matrix);
                    }
                    else if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        char clientMoney = matrix[playerRow, playerCol];
                        money += int.Parse(clientMoney.ToString());
                    }
                }
                else if (command == "right")
                {
                    playerCol += 1;

                    if (matrix.GetLength(0) <= playerCol)
                    {
                        isItOut = true;
                        break;
                    }
                    if (matrix[playerRow, playerCol] == 'O')
                    {
                        PillarMove(ref playerRow, ref playerCol, firstPillarRow, firstPillarCol, secondPillarRow, secondPillarCol, matrix);
                    }
                    else if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        char clientMoney = matrix[playerRow, playerCol];
                        money += int.Parse(clientMoney.ToString());
                    }
                }
                matrix[playerRow, playerCol] = 'S';

                if (money >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }

            if (isItOut)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }

            Console.WriteLine($"Money: {money}");

            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }


        private static void PillarMove(ref int playerRow, ref int playerCol, int firstPillarRow, int firstPillarCol, int secondPillarRow, int secondPillarCol, char[,] matrix)
        {
            matrix[playerRow, playerCol] = '-';

            if ((playerRow == firstPillarRow && playerCol == firstPillarCol))
            {
                playerRow = secondPillarRow;
                playerCol = secondPillarCol;
            }
            else if (playerRow == secondPillarRow && playerCol == secondPillarCol)
            {
                playerRow = firstPillarRow;
                playerCol = firstPillarCol;
            }

            matrix[playerRow, playerCol] = 'S';
        }

        private static void ReadMatrix(int n, ref int playerRow, ref int playerCol, ref int firstPillarRow, ref int firstPillarCol, ref int secondPillarRow, ref int secondPillarCol, ref bool isFirstPillarFound, char[,] matrix)
        {
            for (int rows = 0; rows < n; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < n; cols++)
                {
                    if (input[cols] == 'S')
                    {
                        playerRow = rows;
                        playerCol = cols;
                    }
                    else if (input[cols] == 'O' && !isFirstPillarFound)
                    {
                        firstPillarRow = rows;
                        firstPillarCol = cols;

                        isFirstPillarFound = true;
                    }
                    else if (input[cols] == 'O' && isFirstPillarFound)
                    {
                        secondPillarRow = rows;
                        secondPillarCol = cols;
                    }

                    matrix[rows, cols] = input[cols];
                }
            }
        }

    }
}
