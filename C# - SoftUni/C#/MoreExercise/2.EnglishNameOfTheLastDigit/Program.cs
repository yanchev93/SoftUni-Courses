using System;

namespace _2.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {

                if (i == number.Length - 1)
                {
                    if (number[i] == '1')
                    {
                        output = "one";
                    }
                    else if (number[i] == '2')
                    {
                        output = "two";
                    }
                    else if (number[i] == '3')
                    {
                        output = "three";
                    }
                    else if (number[i] == '4')
                    {
                        output = "four";
                    }
                    else if (number[i] == '5')
                    {
                        output = "five";
                    }
                    else if (number[i] == '5')
                    {
                        output = "five";
                    }
                    else if (number[i] == '6')
                    {
                        output = "six";
                    }
                    else if (number[i] == '7')
                    {
                        output = "seven";
                    }
                    else if (number[i] == '8')
                    {
                        output = "eight";
                    }
                    else if (number[i] == '9')
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
    }
}
