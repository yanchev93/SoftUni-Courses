using System;
using System.Linq;

namespace _4.ReversArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayString = Console.ReadLine();
            string[] array = arrayString.Split().ToArray();
            int arrayLength = array.Length;

            for (int i = arrayLength - 1 ; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }

        }
    }
}
