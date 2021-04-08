using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _2.ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<string> command = Console.ReadLine()
                                   .Split()
                                   .ToList();
            while (command[0] != "end")
            {
                string firstCommand = command[0];
                if (firstCommand == "Delete")
                {
                    // int x = int.Parse(command[1]);
                    // numbers.RemoveAt(0);
                    numbers.RemoveAll(x => x == int.Parse(command[1]));

                    command = Console.ReadLine()
                                   .Split()
                                   .ToList();
                    continue;
                }

                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(command[1]);
                    int number = int.Parse(command[2]);
                    numbers.Insert(number, index);

                    command = Console.ReadLine()
                                   .Split()
                                   .ToList();
                    continue;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
