using System;

namespace _09.Mining
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int spice = 0;
            int realSpice = 0;
            while (startingYield >= 100)
            {
                spice = startingYield;
                days += 1;
                spice -= 26;
                realSpice += spice;
                startingYield -= 10;
            }
            if (realSpice >= 26)
            {
                realSpice -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(realSpice);
        }
    }
}
