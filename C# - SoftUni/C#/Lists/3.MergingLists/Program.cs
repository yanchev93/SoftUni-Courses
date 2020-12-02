using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> secondList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> result = new List<int>();
            int numberFirst = firstList.Count;
            int numberSecond = secondList.Count;

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {

                if (numberFirst > 0)
                {
                    result.Add(firstList[i]);
                    numberFirst -= 1;
                }

                if (numberSecond > 0)
                {
                    result.Add(secondList[i]);
                    numberSecond -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
