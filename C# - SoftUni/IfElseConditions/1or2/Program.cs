using System;

namespace biggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberOne);
            }
        }
    }
}
