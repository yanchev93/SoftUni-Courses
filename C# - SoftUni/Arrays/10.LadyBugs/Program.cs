using System;
using System.Data;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];
                
                field[currentIndex] = 1;

                if (currentIndex >= 0 && currentIndex < field.Length)
                {

                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine())!= "end")
            {
                string[] elements = command.Split(); // "0" "right" "1"
                int ladyBugIndex = int.Parse(elements[0]);
                string flyDirection = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }


                
            }
        }
    }
}
