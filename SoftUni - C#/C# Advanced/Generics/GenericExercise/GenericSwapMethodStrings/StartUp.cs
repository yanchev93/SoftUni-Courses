namespace GenericSwapMethodStrings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                box.Add(input);
            }

            int[] swapIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstIndex = swapIndexes[0];
            int secondIndex = swapIndexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
