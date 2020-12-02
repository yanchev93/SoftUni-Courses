using System;
using System.Data.SqlTypes;

namespace IfElseSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double moneySaved = 0;
            int brother = 0;
            double toysForBirthdays = 0;
            double totalMoney = 0;
            double diff = 0;

            for (int i = 1; i <= years; i += 1)
            {
                if (i % 2 == 0)
                {
                    moneySaved += 10;
                    totalMoney += moneySaved;
                    brother += 1;
                }
                else
                {
                    toysForBirthdays += 1;
                }
            }

            toysForBirthdays *= toysPrice;
            totalMoney += toysForBirthdays - brother;
            diff = Math.Abs(totalMoney - washingMachine);
            string output = string.Empty;

            if (totalMoney >= washingMachine)
            {
                output = $"Yes! {diff:f2}";
            }
            else
            {
                output = $"No! {diff:f2}";
            }
            Console.WriteLine(output);
        }
    }
}
