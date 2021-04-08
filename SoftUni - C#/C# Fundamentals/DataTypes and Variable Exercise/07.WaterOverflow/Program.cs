using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int littersFilled = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters + littersFilled > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littersFilled += liters;
                }
            }
            Console.WriteLine(littersFilled);
        }
    }
}
