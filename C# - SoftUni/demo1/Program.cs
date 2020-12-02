using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._HelloFrance
{
    class HelloFrance
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                             .Split(new Char[] { '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                             .ToList();
            decimal budget = decimal.Parse(Console.ReadLine());
            List<decimal> newPrices = new List<decimal>();
            decimal profit = 0.00m;

            for (int i = 0; i < input.Count; i += 2)
            {
                string product = input[i];
                decimal price = decimal.Parse(input[i + 1]);

                bool dontBuyClothes = (product == "Clothes" && price > 50.00m) || (product == "Clothes" && budget < price);
                bool dontBuyShoes = (product == "Shoes" && price > 35.00m) || (product == "Shoes" && budget < price);
                bool dontBuyAccessories = (product == "Accessories" && price > 20.50m) || (product == "Accessories" && budget < price);

                if (dontBuyClothes)
                {
                    continue;
                }
                else if (dontBuyShoes)
                {
                    continue;
                }
                else if (dontBuyAccessories)
                {
                    continue;
                }
                else
                {
                    decimal increasedPrice = 0.00m;
                    budget -= price;
                    increasedPrice = price * 1.40m;
                    newPrices.Add(increasedPrice);
                    profit += (increasedPrice - price);
                }
            }

            for (int i = 0; i < newPrices.Count; i++)
            {
                string printPrice = $"{newPrices[i]:F2} ";
                Console.Write(printPrice);
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");
            decimal total = newPrices.Sum() + budget;

            if (total >= 150.00m)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
