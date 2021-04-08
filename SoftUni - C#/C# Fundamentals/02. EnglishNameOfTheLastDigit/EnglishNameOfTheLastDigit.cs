using System;

namespace _02._EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = number % 10;
            string output = string.Empty;

            if (result == 1)
            {
                output = "one";
            }
            else if (result == 2)
            {
                output = "two";
            }
            else if (result == 3)
            {
                output = "three";
            }
            else if (result == 4)
            {
                output = "four";
            }
            else if (result == 5)
            {
                output = "five";
            }
            else if (result == 6)
            {
                output = "six";
            }
            else if (result == 7)
            {
                output = "seven";
            }
            else if (result == 8)
            {
                output = "eight";
            }
            else if (result == 9)
            {
                output = "nine";
            }
            else
            {
                output = "zero";
            }

            Console.WriteLine(output);
        }
    }
}
