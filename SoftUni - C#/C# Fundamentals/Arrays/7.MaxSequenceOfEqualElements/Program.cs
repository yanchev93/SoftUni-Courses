using System;
using System.Linq;
using System.Threading;

namespace _7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 2 1 1 2 3 3 2 2 2 1
            int bestLength = 0;
            int length = 1;
            int index = 0;
            int bestIndex = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    length += 1;
                }
                else
                {
                    index = i + 1;
                    length = 1;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestIndex = index;
                }
            }
            for (int i = bestIndex; i < bestIndex + bestLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
