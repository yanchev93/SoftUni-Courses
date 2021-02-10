namespace P01.Scheduling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Stack<int> tasks = new Stack<int>(InputTask());
            Queue<int> threads = new Queue<int>(InputThread());
            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");

                    break;
                }

                if (currentThread >= currentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(' ', threads));
        }

        private static int[] InputThread()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static int[] InputTask()
        {
            return Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}
