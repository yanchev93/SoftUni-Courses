using System;
using System.Linq;

namespace _08._KnightGame
{
    class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chestBoard = new char[size, size];

            for (int row = 0; row < chestBoard.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chestBoard.GetLength(1); col++)
                {
                    chestBoard[row, col] = input[col];
                }
            }

            int removedKnights = 0;
            while (true)
            {
                int maxAttacks = 0;
                int removeKnightRow = 0;
                int removeKnightCol = 0;

                for (int row = 0; row < chestBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chestBoard.GetLength(1); col++)
                    {
                        int attackedKnight = 0;
                        if (chestBoard[row, col] == 'K')
                        {

                            // -2, -1
                            if (IsInside(chestBoard, row - 2, col - 1) &&
                                chestBoard[row - 2, col - 1] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // -2, +1
                            if (IsInside(chestBoard, row - 2, col + 1) &&
                                chestBoard[row - 2, col + 1] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // -1, -2
                            if (IsInside(chestBoard, row - 1, col - 2) &&
                                chestBoard[row - 1, col - 2] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // -1, +2
                            if (IsInside(chestBoard, row - 1, col + 2) &&
                                chestBoard[row - 1, col + 2] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // +2, -1
                            if (IsInside(chestBoard, row + 2, col - 1) &&
                                chestBoard[row + 2, col - 1] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // +2, +1
                            if (IsInside(chestBoard, row + 2, col + 1) &&
                                chestBoard[row + 2, col + 1] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // +1, -2
                            if (IsInside(chestBoard, row + 1, col - 2) &&
                                chestBoard[row + 1, col - 2] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // +1, +2
                            if (IsInside(chestBoard, row + 1, col + 2) &&
                                chestBoard[row + 1, col + 2] == 'K')
                            {
                                attackedKnight += 1;
                            }

                            // TODO -> maxKnight 
                            if (maxAttacks < attackedKnight)
                            {
                                maxAttacks = attackedKnight;
                                removeKnightRow = row;
                                removeKnightCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chestBoard[removeKnightRow, removeKnightCol] = '0';
                    removedKnights += 1;
                }

                if (maxAttacks == 0)
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }
        private static bool IsInside(char[,] chestboard, int row, int col)
        {
            bool isInside = false;

            if ((0 <= row && row < chestboard.GetLength(0)) &&
                (0 <= col && col < chestboard.GetLength(1)))
            {
                isInside = true;
            }

            return isInside;
        }
    }
}
