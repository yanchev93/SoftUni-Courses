using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Orders
    {
        static void Main()
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] currentProduct = command.Split();
                string typeProduct = currentProduct[0];
                double price = double.Parse(currentProduct[1]);
                double quantity = double.Parse(currentProduct[2]);

                if (!products.ContainsKey(typeProduct))
                {
                    products[typeProduct] = new List<double>();

                    products[typeProduct].Add(price);
                    products[typeProduct].Add(quantity);
                }
                else if (products.ContainsKey(typeProduct))
                {
                    products[typeProduct][1] += quantity;
                    if (products[typeProduct][0] != price)
                    {
                        products[typeProduct].RemoveAt(0);
                        products[typeProduct].Insert(0, price);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var totalPrice in products)
            {
                List<double> priceNquantity = totalPrice.Value;

                double price = priceNquantity[0];
                double quantity = priceNquantity[0];

                double total = price * quantity;

                Console.WriteLine($"{totalPrice.Key} -> {total:f2}");
            }
        }
    }
}
