using System;
using System.Linq;

namespace ArraysExercise
{
    class Program
    {
        private static object input;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] waggons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                waggons[i] = int.Parse(Console.ReadLine());                
                sum += waggons[i];
            }
            Console.WriteLine(string.Join(' ', waggons));
            Console.WriteLine(sum);
        }
    }
}
