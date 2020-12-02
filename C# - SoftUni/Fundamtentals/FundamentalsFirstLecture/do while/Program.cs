using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double pricePerLightsabers = double.Parse(Console.ReadLine());
            double pricePerRobes = double.Parse(Console.ReadLine());
            double pricePerBelts = double.Parse(Console.ReadLine());                       

            double lightsabers = (countOfStudents + Math.Ceiling(countOfStudents * 0.10)) * pricePerLightsabers;
            double robes = countOfStudents * pricePerRobes;
            double belts = countOfStudents;
            int beltCount = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                beltCount += 1;
                if (beltCount % 6 == 0)
                {
                    belts -= 1;
                }               
            }

            belts *= pricePerBelts;
            double sum = Math.Abs(belts + lightsabers + robes);
            double diff = sum - amountOfMoney;

            if (amountOfMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
            
            
                        
        }   
    }
}