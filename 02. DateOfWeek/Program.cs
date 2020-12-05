using System;
using System.Globalization;

namespace _02._DateOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime Date = DateTime.ParseExact(dateString, "d-M-yyyy", 
                CultureInfo.InvariantCulture);

            Console.WriteLine(Date.DayOfWeek);
        }
    }
}
