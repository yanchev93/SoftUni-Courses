using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            Stack<string> numbers = new Stack<string>(values.Reverse());

            int sum = 0;
            while (numbers.Count > 1)
            {
                int firstNum = int.Parse(numbers.Pop());
                string addOrSub = numbers.Pop();
                int secondNum = int.Parse(numbers.Pop());
                if (addOrSub == "-")
                {
                    numbers.Push((firstNum - secondNum).ToString());
                }

                else
                {
                    numbers.Push((firstNum + secondNum).ToString());
                }
            }

            Console.WriteLine(numbers.Pop());
        }
    }
}

