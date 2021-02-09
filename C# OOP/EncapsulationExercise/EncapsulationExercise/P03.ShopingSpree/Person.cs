namespace P03.ShopingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ConstantExceptions.NameException);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ConstantExceptions.MoneyException);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return this.bag;
            }
        }

        public void BuyProduct(Product product)
        {

            if (this.Money < product.Cost)
            {
                
                throw new InvalidOperationException(string.Format(ConstantExceptions.InsufficientMoneyExceptionMessage,
                    this.Name, product.Name));
            }

            this.Money -= product.Cost;

            this.bag.Add(product);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? string.Join(", ", this.bag)
                : "Nothing bought";

            return $"{this.Name} - {productsOutput}";
        }
    }
}
