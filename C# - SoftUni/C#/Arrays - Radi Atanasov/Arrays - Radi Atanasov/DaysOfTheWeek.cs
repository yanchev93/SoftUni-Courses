using System;

namespace Arrays___Radi_Atanasov
{
    class DaysOfTheWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            if (1 <= n && n <=7)
            {
                Console.WriteLine(daysOfTheWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
