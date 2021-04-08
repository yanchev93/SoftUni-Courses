using System;

namespace NewTry.MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultiplyEveneByOdds(number);
            Console.WriteLine(result);
        }

        static int MultiplyEveneByOdds(int number)
        {
            int result = FindEvenNumbers(number) * FindOddNumbers(number);
            return result;
        }

        static int FindEvenNumbers(int number)
        {
            int newNumber = number;
            int evenNumbers = 0;

            while (newNumber != 0)
            {
                int num = newNumber % 10;
                if (num % 2 == 0)
                {
                    evenNumbers += num;
                }
                newNumber -= num;
                newNumber /= 10;
            }

            return evenNumbers;
        }
        
        static int FindOddNumbers(int number)
        {
            int newNumber = number;
            int oddNumbers = 0;

            while (newNumber != 0)
            {
                int num = newNumber % 10;
                if (num % 2 == 1)
                {
                    oddNumbers += num;
                }
                newNumber -= num;
                newNumber /= 10;
            }

            return oddNumbers;
        }
    }
}
