namespace P04.PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;

        private Dough dough;

        private List<Topping> toppings;

        private int numberOfToppings => this.toppings.Count;

        private double totalCalories => TotalCaloriesPizza();

        public Pizza()
        {
            this.toppings = new List<Topping>();
        }

        public Pizza(string name, Dough dough)
            : this()
        {
            this.Name = name;
            this.dough = dough;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || 15 < value.Length)
                {
                    string excPizzaNameMsg = ExceptionMessages.InvalidPizzaName;

                    throw new ArgumentException(excPizzaNameMsg);
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }
        }

        public double TotalCalories
        {
            get
            {
                return this.totalCalories;
            }
        }

        private double TotalCaloriesPizza()
        {
            double totalCal = this.toppings
                                .Select(x => x.CaloriesPerGram)
                                .Sum();

            totalCal += this.dough.CaloriesPerGram;

            return totalCal;
        }

        public void AddTopping(Topping topping)
        {
            if (10 <= this.NumberOfToppings)
            {
                string excNumberOfToppings = ExceptionMessages.InvalidRangeOfToppings;

                throw new ArgumentException(excNumberOfToppings);
            }
            else
            {
                this.toppings.Add(topping);
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:f2} Calories.";
        }
    }
}
