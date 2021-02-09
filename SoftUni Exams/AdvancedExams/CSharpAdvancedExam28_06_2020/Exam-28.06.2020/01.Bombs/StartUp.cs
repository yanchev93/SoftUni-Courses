namespace _01.Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            const int NEEDED_BOMBS = 3;
            const int DATURA_BOMB = 40;
            const int CHERRY_BOMB = 60;
            const int SMOKE_DECOY_BOMB = 120;

            Queue<int> bombEffects = new Queue<int>(ReadInput());
            Stack<int> bombCasings = new Stack<int>(ReadInput());

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeDecoyCount = 0;
            bool areBombsCreated = false;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                bool creatingBomb = false;
                int bombEffect = bombEffects.Peek();
                int bombCasing = bombCasings.Peek();

                int bombSum = bombEffect + bombCasing;

                if (bombSum == DATURA_BOMB)
                {
                    daturaCount += 1;

                    creatingBomb = true;
                }
                else if (bombSum == CHERRY_BOMB)
                {
                    cherryCount += 1;

                    creatingBomb = true;
                }
                else if (bombSum == SMOKE_DECOY_BOMB)
                {
                    smokeDecoyCount += 1;

                    creatingBomb = true;
                }
                else
                {
                    int decreaseCasing = bombCasings.Pop();
                    decreaseCasing -= 5;

                    bombCasings.Push(decreaseCasing);
                }

                if (creatingBomb)
                {
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }

                if (daturaCount >= NEEDED_BOMBS
                    && cherryCount >= NEEDED_BOMBS
                    && smokeDecoyCount >= NEEDED_BOMBS)
                {
                    areBombsCreated = true;
                    break;
                }
                
            }

            if (areBombsCreated)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCount}");
        }

        private static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
