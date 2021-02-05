namespace Restaurant
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Product coldBeverage = new ColdBeverage("Icecream Shake", 5.50m, 450);
            Product coffee = new Coffee("Double Espresso", 2);

            Console.WriteLine(coldBeverage.Name);
            Console.WriteLine(coffee.Name);
            Console.WriteLine(coldBeverage.Name);
            Console.WriteLine(coldBeverage.Name);
            Console.WriteLine(coldBeverage.Name);



        }
    }
}