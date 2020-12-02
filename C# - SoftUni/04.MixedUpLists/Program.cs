using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main()
        {
            List<int> firstListOfNumbers = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            List<int> secondListOfNumbers = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            List<int> mixedList = new List<int>();
            List<int> finnishedList = new List<int>();

            int firstNum;
            int secondNum;

            while (firstListOfNumbers.Count > 0 && secondListOfNumbers.Count > 0)
            {
                
                for (int i = 0; i < firstListOfNumbers.Count; i++)
                {
                    mixedList.Add(firstListOfNumbers[i]);
                    firstListOfNumbers.RemoveAt(i);
                    break;
                }

                for (int j = secondListOfNumbers.Count - 1; j >= 0; j--)
                {
                    mixedList.Add(secondListOfNumbers[j]);
                    secondListOfNumbers.RemoveAt(j);
                    break;
                }
            }

            if (firstListOfNumbers.Count == 2)
            {
                firstNum = firstListOfNumbers[0];
                secondNum = firstListOfNumbers[1];

                for (int i = 0; i < mixedList.Count; i++)
                {
                    if (firstNum > mixedList[i] && mixedList[i] > secondNum)
                    {
                        finnishedList.Add(mixedList[i]);
                    }

                    else if (secondNum > mixedList[i] && mixedList[i] > firstNum)
                    {
                        finnishedList.Add(mixedList[i]);
                    }
                }
            }

            else if (secondListOfNumbers.Count == 2)
            {

                firstNum = secondListOfNumbers[0];
                secondNum = secondListOfNumbers[1];
                for (int i = 0; i < mixedList.Count; i++)
                {
                    if (firstNum > mixedList[i] && mixedList[i] > secondNum)
                    {
                        finnishedList.Add(mixedList[i]);
                    }

                    else if (secondNum > mixedList[i] && mixedList[i] > firstNum)
                    {
                        finnishedList.Add(mixedList[i]);
                    }
                }
            }

            finnishedList.Sort();
            Console.WriteLine(string.Join(' ', finnishedList));
        }
    }
}
