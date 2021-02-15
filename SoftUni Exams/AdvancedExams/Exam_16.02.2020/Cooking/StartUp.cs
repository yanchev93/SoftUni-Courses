namespace Cooking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            const int BREAD = 25;
            const int CAKE = 50;
            const int PASTRY = 75;
            const int FRUIT_PIE = 100;

            Queue<int> liquids = new Queue<int>(Input());
            Stack<int> ingredients = new Stack<int>(Input());

            int breadCount = 0;
            int cakeCount = 0;
            int pastryCount = 0;
            int fruitPieCount = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currentLiquid = liquids.Peek();
                int currentIngredients = ingredients.Peek();

                int sum = currentIngredients + currentLiquid;
                bool isItCooked = false;

                if (sum == BREAD)
                {
                    breadCount += 1;

                    isItCooked = true;
                }
                else if (sum == CAKE)
                {
                    cakeCount += 1;

                    isItCooked = true;
                }
                else if (sum == PASTRY)
                {
                    pastryCount += 1;

                    isItCooked = true;
                }
                else if (sum == FRUIT_PIE)
                {
                    fruitPieCount += 1;

                    isItCooked = true;
                }
                else
                {
                    liquids.Dequeue();

                    int ingredient = ingredients.Pop();
                    ingredient += 3;

                    ingredients.Push(ingredient);
                }

                if (isItCooked)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                }
            }

            if (breadCount > 0
                && cakeCount > 0
                && pastryCount > 0
                && fruitPieCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");

        }

        private static int[] Input()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
