using System;

namespace _06._TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = (int)('a'); i < (int)('a') + number; i++)
            {
                for (int j = (int)('a'); j < (int)('a') + number; j++)
                {
                    for (int k = (int)('a'); k < (int)('a') + number; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
