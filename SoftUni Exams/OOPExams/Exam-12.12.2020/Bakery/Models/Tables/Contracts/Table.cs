namespace Bakery.Models.Tables.Contracts
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    
    using Bakery.Models.BakedFoods.Contracts;
    using Bakery.Models.Drinks.Contracts;

    public abstract class Table : ITable
    {
        private int tableNumber;
        private int capacity;
        private int numberOfPeople;
        private decimal pricePerPerson;
        private bool isReserved;
        private decimal price;
        private readonly List<IBakedFood> foodOrders;
        private readonly List<IDrink> drinkOrders;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.foodOrders = new List<IBakedFood>();
            this.drinkOrders = new List<IDrink>();

            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber
        {
            get
            {
                return this.tableNumber;
            }
            private set
            {
                this.tableNumber = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }

                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson
        {
            get
            {
                return this.pricePerPerson;
            }
            private set
            {
                this.pricePerPerson = value;
            }
        }

        public bool IsReserved
        {
            get
            {
                return this.isReserved;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;

            this.isReserved = true;
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public decimal GetBill()
        {
            decimal bill = 0;


            foreach (var food in this.foodOrders)
            {
                bill += food.Price;
            }

            foreach (var drink in this.drinkOrders)
            {
                bill += drink.Price;
            }

            bill += this.PricePerPerson * this.NumberOfPeople;

            return bill;
        }

        public void Clear()
        {
            this.drinkOrders.Clear();
            this.foodOrders.Clear();

            this.isReserved = false;
            this.numberOfPeople = 0;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}")
              .AppendLine($"Type: {this.GetType().Name}")
              .AppendLine($"Capacity: {this.Capacity}")
              .AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString().TrimEnd();
        }


    }
}
