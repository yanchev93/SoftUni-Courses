namespace Bee
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;

            ReadMatrix(n, matrix, ref beeRow, ref beeCol);

            int flowers = 0;
            bool isItOut = false;

            string command = Console.ReadLine();
            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';

                if (command == "up")
                {
                    beeRow -= 1;

                    if (beeRow < 0)
                    {
                        isItOut = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeRow -= 1;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            flowers += 1;
                        }
                    }
                    else if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers += 1;
                    }
                }
                else if (command == "down")
                {
                    beeRow += 1;

                    if (matrix.GetLength(0) <= beeRow)
                    {
                        isItOut = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeRow += 1;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            flowers += 1;
                        }
                    }
                    else if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers += 1;
                    }
                }
                else if (command == "left")
                {
                    beeCol -= 1;

                    if (beeCol < 0)
                    {
                        isItOut = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeCol -= 1;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            flowers += 1;
                        }
                    }
                    else if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers += 1;
                    }
                }
                else if (command == "right")
                {
                    beeCol += 1;

                    if (matrix.GetLength(1) <= beeCol)
                    {
                        isItOut = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeCol += 1;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            flowers += 1;
                        }
                    }
                    else if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowers += 1;
                    }
                }

                matrix[beeRow, beeCol] = 'B';

                command = Console.ReadLine();
            }

            if (isItOut)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (flowers < 5)
            {
                int needed = 5 - flowers;
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {needed} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }

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

        private static void ReadMatrix(int n, char[,] matrix, ref int beeRow, ref int beeCol)
        {
            for (int rows = 0; rows < n; rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < n; cols++)
                {
                    if (input[cols] == 'B')
                    {
                        beeRow = rows;
                        beeCol = cols;
                    }

                    matrix[rows, cols] = input[cols];
                }
            }
        }
    }
}
