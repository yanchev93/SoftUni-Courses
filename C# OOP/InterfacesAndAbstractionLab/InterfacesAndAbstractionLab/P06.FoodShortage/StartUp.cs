namespace P06.FoodShortage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthday = input[3];

                    IBuyer citizen = new Citizen(name, age, id, birthday);

                    buyers.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    IBuyer rebel = new Rebel(name, age, group);

                    buyers.Add(rebel);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b=>b.Food));
        }
    }
}
