using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    public class StartUp
    {
        public static void Main()
        {
            int[] firstInput = ReadInput();
            int[] secondInput = ReadInput();

            Queue<int> firstLootBox = new Queue<int>(firstInput);
            Stack<int> secondLootBox = new Stack<int>(secondInput);

            int collectionBox = 0;

            while (true)
            {
                if (firstLootBox.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                else if (secondLootBox.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }

                int currentFirst = firstLootBox.Peek();
                int currentSecond = secondLootBox.Peek();

                int sum = currentFirst + currentSecond;

                if (sum % 2 == 0)
                {
                    collectionBox += sum;

                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                    continue;
                }
                else
                {
                    firstLootBox.Enqueue(currentSecond);
                    secondLootBox.Pop();
                }
            }

            if (collectionBox >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collectionBox}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collectionBox}");
            }
        }

        private static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
