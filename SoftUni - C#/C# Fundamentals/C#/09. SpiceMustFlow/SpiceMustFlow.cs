using System;

namespace _09._SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int extracted = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                days += 1;
                extracted += startingYield;

                startingYield -= 10;
                if (extracted >= 26)
                {
                    extracted -= 26;
                    continue;
                }
                
            }

            if (extracted >= 26)
            {
                extracted -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(extracted);

        }
    }
}
