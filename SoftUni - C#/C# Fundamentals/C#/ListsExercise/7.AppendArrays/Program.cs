using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();                                ;

            string newNumbers = string.Empty;
            while (numbers.Length != 0)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (numbers[i] == '|')
                    {
                        for (int j = i; j < numbers.Length; j++)
                        {
                            if (numbers[j] == '|' || numbers[j] == ' ')
                            {
                                numbers.Remove(j);
                                continue;
                            }
                                newNumbers += numbers[j];
                                numbers.(numbers[j]);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
