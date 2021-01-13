using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double result = DateModifier.CalculateDaysBetween(firstDate,secondDate);

            Console.WriteLine(Math.Abs(result));
        }
    }
}
