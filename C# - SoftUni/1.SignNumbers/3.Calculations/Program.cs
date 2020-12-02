using System;
using System.ComponentModel.Design;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            Calculation(firstLine, numberOne, numberTwo);

        }

        static void Calculation(string firstLine, double numberOne, double numberTwo)
        {
            double output = 0;

            if (firstLine == "add")
            {
                output = numberOne + numberTwo;
            }
            else if (firstLine == "multiply")
            {
                output = numberOne * numberTwo;
            }
            else if (firstLine == "substract")
            {
                output = numberOne - numberTwo;
            }
            else if (firstLine == "divide")
            {
                output = numberOne / numberTwo;
            }
            Console.WriteLine(output);
        }
    }
}
