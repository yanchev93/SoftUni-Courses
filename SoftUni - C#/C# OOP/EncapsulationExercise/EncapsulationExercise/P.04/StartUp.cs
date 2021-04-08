using System;

namespace P04.PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {

            try
            {
                string[] pizzaInput = Console.ReadLine()
                                      .Split(' ');
                string pizzaName = pizzaInput[1];

                string[] doughInput = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string doughFlourType = doughInput[1];
                string doughBakingTechnique = doughInput[2];
                double doughWeight = double.Parse(doughInput[3]);


                Dough dough = new Dough(doughFlourType, doughBakingTechnique, doughWeight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] input = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string toppingType = input[1];
                    double toppingWeight = double.Parse(input[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
