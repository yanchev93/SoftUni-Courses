using System;
using System.Linq;
using System.Xml;

namespace _02._CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            string winner = string.Empty;
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < time.Length / 2; i++)
            {
                if (time[i] == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += time[i];
                }
            }

            for (int i = time.Length - 1; i > time.Length / 2 ; i--)
            {
                if (time[i] == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += time[i];
                }
            }

            if (leftTime < rightTime)
            {
                winner = $"The winner is left with total time: {leftTime}";
            }
            else
            {
                winner = $"The winner is right with total time: {rightTime}";
            }
            Console.WriteLine(winner);
        }
    }
}
