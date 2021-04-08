using System;
using System.Linq;

namespace _4.ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstNumber = array[0];
                int[] temp = new int[array.Length];

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j];
                }

                temp[temp.Length - 1] = firstNumber;
                array = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
