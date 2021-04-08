using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx_Exercise
{
    class Furniture
    {
        static void Main()
        {
            double totalPrice = 0.00;

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+.?\d*)!(?<qty>\d+)";
            
            List<string> furnitures = new List<string>();

            string command = Console.ReadLine();
            while (command != "Purchase")
            {
                Match match = Regex.Match(command, pattern);

                if (match.Success)
                {
                    string currentFurniture = match.Groups["name"].Value;

                    furnitures.Add(currentFurniture);
                    totalPrice += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["qty"].Value);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (totalPrice > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
