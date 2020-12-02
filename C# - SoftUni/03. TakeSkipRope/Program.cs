using System;
using System.Collections.Generic;

namespace _03._TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            List<string> nonNumbers = new List<string>();
            List<int> numbers = new List<int>();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();


            // Taking every digit from the string
            for (int i = 0; i < message.Length; i++)
            {
                if ('0' >= message[i] || message[i] <= '9')
                {
                    int number = int.Parse(message[i].ToString());
                    numbers.Add(number);
                }
                else
                {
                    nonNumbers.Add(message[i].ToString());
                }

            }

            // Creating Take List and Skip List
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }



            Console.WriteLine($"The string that I receive -> {(string.Join(' ', nonNumbers))}") ;
            Console.WriteLine($"The numbers taken from the string -> {(string.Join(' ', numbers))}");
            Console.WriteLine($"Take List -> {(string.Join(' ', takeList))}");
            Console.WriteLine($"Skip List -> {(string.Join(' ', skipList))}");
        }
    }
}
