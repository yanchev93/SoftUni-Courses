using System;

namespace _07._WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int waterTank = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                waterTank += liters;
                if (waterTank > 255)
                {
                    waterTank -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(waterTank);
        }
    }
}
