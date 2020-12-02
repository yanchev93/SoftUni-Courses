using System;

namespace _04._CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            int minutes = hours * 60;

            string output = $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes";
            Console.WriteLine(output);
        }
    }
}
