using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToList();

            List<int> bombNumber = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToList();

            int bomb = bombNumber[0];
            int bombPower = bombNumber[1];
            int currentIndexBomb = numbers.IndexOf(bomb);
            int count = 0;
            bool left = true;
            bool right = true;

            while (numbers.Contains(bomb))
            {
                
                if (left)
                {
                    while (count < bombPower)
                    {
                        count += 1;
                        currentIndexBomb = numbers.IndexOf(bomb);
                        if (currentIndexBomb == 0)
                        {
                            left = false;
                            break;
                        }

                        else
                        {
                            for (int i = currentIndexBomb; i > 0; i--)
                            {
                                int index = currentIndexBomb - 1;                            
                                numbers.RemoveAt(index);
                                break;                            
                            }
                            left = false;
                        }
                    }

                    count = 0;
                    
                }

                if (right)
                {
                    while (count < bombPower)
                    {
                        count += 1;
                        currentIndexBomb = numbers.IndexOf(bomb);
                        if (currentIndexBomb == numbers.Count - 1)
                        {
                            right = false;
                            break;
                        }

                        else
                        {
                            int range = numbers.IndexOf(bomb) + bombPower;
                            for (int i = currentIndexBomb; i <= range; i++)
                            {
                                int index = currentIndexBomb + 1;
                                numbers.RemoveAt(index);
                                break;
                            }
                            right = false;
                        }
                    }
                    numbers.Remove(bomb);
                    count = 0;

                    if (numbers.Contains(bomb))
                    {
                        left = true;
                        right = true;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
