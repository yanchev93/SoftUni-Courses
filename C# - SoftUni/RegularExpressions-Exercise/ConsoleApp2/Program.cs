using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @">>(?<name>\w+)<<(?<price>\d+\.?\d*)!(?<qty>\d+)\b";
            string pattern = @">>(?<name>\w+)<<(?<price>\d+\.?\d*?)!(?<qty>\d+)\b";
            double moneySpent = 0.00;
            List<string> name = new List<string>();

            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match data in matches)
                {
                    var nameFruniture = data.Groups["name"].Value;
                    var price = double.Parse(data.Groups["price"].Value);
                    var qty = double.Parse(data.Groups["qty"].Value);
                    moneySpent += price * qty;

                    name.Add(nameFruniture);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (moneySpent == 0)
            {
                Console.WriteLine($"Total money spend: {moneySpent:f2}");
            }

            else
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, name)}");
                Console.WriteLine($"Total money spend: {moneySpent:f2}");
            }
        }
    }
}
