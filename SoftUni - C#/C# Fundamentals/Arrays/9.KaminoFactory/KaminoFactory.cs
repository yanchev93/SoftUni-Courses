using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _9.KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int bestLength = 0;
            int bestStartIndex = 0;
            int bestArraySum = 0;
            int bestCounter = 0;
            int counter = 0;

            int[] bestArray = new int[number];

            string command = Console.ReadLine();
            while (command != "Clone them!")
            {
                int[] currentArray = command.
                    Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                counter += 1;
                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentArraySum = 0;

                for (int i = 0; i < currentArray.Length - 1; i++)
                {
                    if (currentArray[i] == currentArray[i + 1])
                    {
                        length += 1;
                    }
                    else
                    {
                        length = 1;                     
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i;
                    }
                    currentArraySum += currentArray[i];
                }

                currentArraySum += currentArray[number - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestArraySum = currentArraySum;
                    bestCounter = counter;
                    bestArray = currentArray.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestArraySum = currentArraySum;
                        bestCounter = counter;
                        bestArray = currentArray.ToArray();
                    }
                    else if (currentArraySum > bestArraySum)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestArraySum = currentArraySum;
                        bestCounter = counter;
                        bestArray = currentArray.ToArray();
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestArraySum}.");
            Console.WriteLine($"{String.Join(" ", bestArray)}");
        }
    }
}
