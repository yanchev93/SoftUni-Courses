namespace P03.ShopingSpree
{
    using System;

    public class Product
    {
        private const decimal MIN_VALUE = 0m;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ConstantExceptions.NameException);
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value < MIN_VALUE)
                {
                    throw new ArgumentException(ConstantExceptions.MoneyException);
                }

                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
