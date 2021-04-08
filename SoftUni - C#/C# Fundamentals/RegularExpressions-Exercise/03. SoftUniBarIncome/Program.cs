using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%(?<ignore>[^|$%.]*?)<(?<product>\w+)>(?<ignore2>[^|$%.]*?)\|(?<count>\d+)\|(?<ignore3>[^|$%.]*?)(?<price>\d+([.]\d+)?)\$";
            double finalSum = 0.00;

            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double sum = int.Parse(match.Groups["count"].Value)
                        * double.Parse(match.Groups["price"].Value);
                    finalSum += sum;
                    Console.WriteLine($"{name}: {product} - {sum:f2}");
                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {finalSum:f2}");
        }
    }
}
