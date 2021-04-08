using System;

namespace _2.CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split();
            var array2 = Console.ReadLine().Split();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] == array1[i])
                    {
                        Console.Write($"{array2[j]} ");
                    }                    
                }
            }
            Console.WriteLine();
        }
    }
}
