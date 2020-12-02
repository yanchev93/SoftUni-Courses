using System;
using System.Xml.Schema;

namespace exerciseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double swimingOneMeterPerSecond = double.Parse(Console.ReadLine());

            double swiming = lenghtInMeters * swimingOneMeterPerSecond;
            double addedTime = (Convert.ToInt32(lenghtInMeters) / 15) * 12.5;
            double addedTimeTwo = (lenghtInMeters / 15) * 12.5;
            //double addedTimeTwo = addedTime * 12.5;
            double totalTime = swiming + addedTime;
            string result = "";
            if (totalTime < recordInSeconds)
            {
               result = ($"Yes, he succeeded! The new world record is {Math.Abs(totalTime):f2} seconds.");
            }
            else
            {
                double diff = totalTime - recordInSeconds;
                result =($"No, he failed! He was {diff:f2} seconds slower.");
            }
            Console.WriteLine(result);
        }
    }
}
