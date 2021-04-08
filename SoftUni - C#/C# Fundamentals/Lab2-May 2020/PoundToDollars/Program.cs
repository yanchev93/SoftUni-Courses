using System;
using System.Text;

namespace PoundToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal GBP = decimal.Parse(Console.ReadLine());            
            decimal USD = GBP * 1.31m;
            Console.WriteLine($"{USD:f3}");
        }
    }
}
