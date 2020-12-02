using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> newListNumbers = new List<int>();
            int number = 0;

            for (int i = 0; i < listNumbers.Count / 2; i++)
            {
                number = listNumbers[i] + listNumbers[listNumbers.Count -i - 1];
                newListNumbers.Add(number);
            }

            if (listNumbers.Count % 2 == 1)
            {
                newListNumbers.Add(listNumbers[listNumbers.Count / 2]);
            }
            
            Console.WriteLine(string.Join(" ", newListNumbers));                        
        }
    }
}
