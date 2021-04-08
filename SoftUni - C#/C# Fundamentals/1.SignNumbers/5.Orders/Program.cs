using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            Reciept(order, quantity);
            
        }
        static void Reciept(string order, double quantity)
        {
            double reciept = 0.0;

            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;

            if (order == "coffee")
            {
                reciept = quantity * coffee;
            }
            else if (order == "water")
            {
                reciept = quantity * water;
            }
            else if (order == "coke")
            {
                reciept = quantity * coke;
            }
            else if (order == "snacks")
            {
                reciept = quantity * snacks;
            }
            Console.WriteLine($"{reciept:f2}");
        }
    }
}
