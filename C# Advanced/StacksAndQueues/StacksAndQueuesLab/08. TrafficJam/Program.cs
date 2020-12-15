using System;
using System.Collections.Generic;

namespace _08._TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queJam = new Queue<string>();
            int count = 0;

            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {

                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queJam.Count > 0)
                        {
                            Console.WriteLine($"{queJam.Dequeue()} passed!");
                            count += 1;
                        }

                    }
                }

                else
                {
                    queJam.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
