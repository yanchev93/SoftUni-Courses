using System;
using System.Linq;

namespace _3.ZigZagArray
{
    class ZigZagArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];


            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    array1[i] = currentArray[1];
                    array2[i] = currentArray[0];
                }
                else
                {
                    array1[i] = currentArray[0];
                    array2[i] = currentArray[1];
                }                
            }
            Console.WriteLine(String.Join(" ", array1));
            Console.WriteLine(String.Join(" ", array2));
        }
    }
}
