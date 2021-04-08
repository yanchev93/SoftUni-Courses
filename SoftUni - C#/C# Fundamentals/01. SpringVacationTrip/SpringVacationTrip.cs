using System;

namespace _01._SpringVacationTrip
{
    class SpringVacationTrip
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPerKM = double.Parse(Console.ReadLine());
            double foodExpensesPerPersonForDay = double.Parse(Console.ReadLine());
            double pricePerRoom1Person1Night = double.Parse(Console.ReadLine());

            double foodExpenses = foodExpensesPerPersonForDay * groupOfPeople * days;
            double totalHotelExpenses = pricePerRoom1Person1Night * groupOfPeople * days;

            if (groupOfPeople > 10)
            {
                totalHotelExpenses *= 0.75;
            }

            double expenses = foodExpenses + totalHotelExpenses;

            for (int i = 1; i <= days; i++)
            {

                double distancePerDay = double.Parse(Console.ReadLine());
                double traveldDistace = (distancePerDay * fuelPerKM);

                expenses += traveldDistace;
                if (i % 3 == 0 || i % 5 == 0 )
                {
                    expenses += (expenses * 0.4);
                }

                if (i % 7 == 0)
                {
                    expenses -= expenses / groupOfPeople;
                }

                if (expenses > budget)
                {
                    double diff = expenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {diff:f2}$ more.");
                    return;
                }
            }

            Console.WriteLine($"You have reached the destination. You have {(budget - expenses):f2}$ budget left.");
        }
    }
}
