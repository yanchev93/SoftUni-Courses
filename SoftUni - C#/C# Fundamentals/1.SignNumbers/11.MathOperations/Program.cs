using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculation(firstNumber, operation, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculation(double firstNumber, string operation, double secondNumber)
        {
            double result = 0.0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }

            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }

            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }

            else if (operation == "/")
            {
                $"{result = firstNumber / secondNumber:d2}";
            }

            return result;
           
        }
    }
}
