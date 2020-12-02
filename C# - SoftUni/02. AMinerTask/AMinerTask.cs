using System;
using System.Collections.Generic;

namespace _02._AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, int> cart = new Dictionary<string, int>();


            
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!cart.ContainsKey(resource))
                {
                    cart[resource] = 0;
                }

                cart[resource] += quantity;
            }

            foreach (var resource in cart)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
