namespace P03.ShopingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly List<Person> people;
        private readonly List<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            AddPeople();
            AddProducts();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command.Split(' ');
                string personName = currentCommand[0];
                string productName = currentCommand[1];

                try
                {
                    Person person = this.people.First(p => p.Name == personName);
                    Product product = this.products.First(p => p.Name == productName);


                    person.BuyProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }


                command = Console.ReadLine();
            }

            foreach (Person person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddProducts()
        {
            string[] allowedProducts = Console.ReadLine().Split(';');

            foreach (var currentProduct in allowedProducts)
            {
                string[] productInfo = currentProduct.Split('=');
                string name = productInfo[0];
                decimal cost = decimal.Parse(productInfo[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] names = Console.ReadLine().Split(';');

            foreach (var name in names)
            {
                string[] personInfo = name.Split('=');
                string personName = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(personName, money);

                this.people.Add(person);
            }
        }
    }
}
