using System;
using System.Xml;

namespace FundamentalsFirstLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string output = string.Empty;

            if (country == "England" || country == "USA")
            {
                output = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                output = "Spanish";
            }
            else
            {
                output = "unknown";
            }
            Console.WriteLine(output);
        }
    }
}
