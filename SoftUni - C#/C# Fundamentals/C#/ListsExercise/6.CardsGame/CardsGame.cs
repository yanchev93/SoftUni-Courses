using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CardsGame
{
    class CardsGame
    {
        static void Main()
        {
            List<int> playerOne = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> playerTwo = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();
            string winner = string.Empty;

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                for (int i = 0; i < Math.Max(playerOne.Count, playerTwo.Count); i++)
                {
                    int temp = 0;
                    if (playerOne[i] > playerTwo[i])
                    {
                        temp = playerOne[i];
                        playerOne.Add(temp);
                        playerOne.Add(playerTwo[i]);
                        playerTwo.RemoveAt(i);
                        playerOne.RemoveAt(i);
                        break;
                    }

                    else if (playerTwo[i] > playerOne[i])
                    {
                        temp = playerTwo[i];
                        playerTwo.Add(temp);
                        playerTwo.Add(playerOne[i]);
                        playerOne.RemoveAt(i);
                        playerTwo.RemoveAt(i);
                        break;
                    }

                    else
                    {
                        playerOne.RemoveAt(i);
                        playerTwo.RemoveAt(i);
                        break;
                    }

                }
            }

            if (playerOne.Count == 0)
            {
                winner = $"Second player wins! Sum: {playerTwo.Sum()}";
            }
            else
            {
                winner = $"First player wins! Sum: {playerOne.Sum()}";
            }

            Console.WriteLine(winner);
        }
    }
}
