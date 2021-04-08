using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPerson = Console.ReadLine().Split(new char[] { ';', '=' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] inputProducts = Console.ReadLine().Split(new char[] { ';', '=' },
                StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < inputPerson.Length; i += 2)
            {
                string name = inputPerson[i];
                int money = int.Parse(inputPerson[i + 1]);

                Person currentPerson = new Person(name, money);
                persons.Add(currentPerson);
            }

            for (int i = 0; i < inputProducts.Length; i += 2)
            {
                string name = inputProducts[i];
                int money = int.Parse(inputProducts[i + 1]);

                Product currentProduct = new Product(name, money);
                products.Add(currentProduct);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command.Split();
                string name = currentCommand[0];
                string productName = currentCommand[1];

                if (persons.Any(n => n.Name == name)
                    && products.Any(p => p.Name == productName))
                {
                    var currentPerson = persons.Find(n => n.Name == name);
                    var currentProduct = products.Find(p => p.Name == productName);

                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        Console.WriteLine($"{name} bought {productName}");

                        currentPerson.BagOfProducts.Add(productName);
                        currentPerson.Money -= currentProduct.Cost;
                    }

                    else if (currentPerson.Money < currentProduct.Cost)
                    {
                        Console.WriteLine($"{name} can't afford {productName}");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Person person in persons)
            {
                string name = person.Name;
                List<string> bagOfProducts = person.BagOfProducts;
                if (bagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{name} - {string.Join(", ", bagOfProducts)}");
                }

                else
                {
                    Console.WriteLine($"{name} - Nothing bought");
                }
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Money { get; set; }
            public List<string> BagOfProducts { get; set; }

            public Person(string name, int money)
            {
                this.Name = name;
                this.Money = money;
                this.BagOfProducts = new List<string>();
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public int Cost { get; set; }

            public Product(string name, int cost)
            {
                this.Name = name;
                this.Cost = cost;
            }
        }
    }
}
