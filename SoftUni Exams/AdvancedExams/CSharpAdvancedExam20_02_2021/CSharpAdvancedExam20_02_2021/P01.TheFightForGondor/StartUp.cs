namespace P01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int waves = int.Parse(Console.ReadLine());
            int[] inputPlates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> plates = new Queue<int>(inputPlates);
            Stack<int> orcs = new Stack<int>();
            for (int i = 1; i <= waves; i++)
            {
                int[] orcsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                orcs = new Stack<int>(orcsInput);

                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                int currentPlate = plates.Peek();
                while (plates.Count > 0 && orcs.Count > 0)
                {
                    int orcWarrior = orcs.Peek();

                    if (orcWarrior > currentPlate)
                    {
                        plates.Dequeue();

                        orcWarrior -= currentPlate;

                        if (plates.Count > 0)
                        {
                            currentPlate = plates.Peek();
                        }

                        orcs.Pop();
                        orcs.Push(orcWarrior);
                    }
                    else if (currentPlate > orcWarrior)
                    {
                        orcs.Pop();

                        currentPlate -= orcWarrior;
                    }
                    else if (currentPlate == orcWarrior)
                    {
                        orcs.Pop();
                        plates.Dequeue();

                        if (plates.Count > 0)
                        {
                            currentPlate = plates.Peek();
                        }
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
