using System;

namespace biggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

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
