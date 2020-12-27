using System;
using System.Collections.Generic;

namespace _03._ProductShop
{
    class Program
    {
        static void Main()
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] currentInput = input.Split(", ",
                    StringSplitOptions.RemoveEmptyEntries);
                string shopName = currentInput[0];
                string product = currentInput[1];
                double price = double.Parse(currentInput[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                }

                var currentShop = shops[shopName];
                if (!currentShop.ContainsKey(product))
                {
                    currentShop[product] = 0.0;
                }

                currentShop[product] = price;

                input = Console.ReadLine();
            }

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}->");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
