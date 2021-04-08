using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries));

            while (songsQueue.Count > 0)
            {
                string input = Console.ReadLine();

                if (input == "Play")
                {
                    songsQueue.Dequeue();
                }

                else if (input.StartsWith("Add"))
                {
                    string song = input.Substring(4);

                    if (!songsQueue.Contains(song))
                    {
                        songsQueue.Enqueue(song);
                    }

                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                
            }

            Console.WriteLine("No more songs!");
        }
    }
}
