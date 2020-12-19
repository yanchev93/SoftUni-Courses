using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _07._TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> amountPetrol = new Queue<int>();
            Queue<int> amountDistance = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int petrol = input[0];
                int distance = input[1];

                amountPetrol.Enqueue(petrol);
                amountDistance.Enqueue(distance);
            }

            int countIndex = 0;

            while (amountPetrol.Count > 0)
            {
                int currentPetrol = 0;
                int currentDistance = 0;
                bool foundIndex = true;

                for (int i = 0; i < n; i++)
                {
                    int tempPetrol = amountPetrol.Peek();
                    int tempDistance = amountDistance.Peek();

                    currentPetrol += amountPetrol.Dequeue();
                    currentDistance += amountDistance.Dequeue();

                    if (currentPetrol < currentDistance)
                    {
                        foundIndex = false;
                    }

                    amountPetrol.Enqueue(tempPetrol);
                    amountDistance.Enqueue(tempDistance);
                }

                if (foundIndex)
                {
                    break;
                }

                countIndex += 1;

                amountPetrol.Enqueue(amountPetrol.Dequeue());
                amountDistance.Enqueue(amountDistance.Dequeue());
            }

            Console.WriteLine(countIndex);
        }
    }
}
