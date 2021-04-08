using System;

namespace P04.PizzaCalories
{
    public class Topping
    {
        private const double BASE_CALLORIES_PER_GRAM = 2.0;

        private const double MEAT = 1.2;

        private const double VEGGIES = 0.8;

        private const double CHEESE = 1.1;

        private const double SAUCE = 0.9;

        private string type;

        private double weight;

        private double caloriesPerGram => MakeTopping();

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
        }

        private string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                string toppingType = value.ToLower();

                if (toppingType == "meat" || toppingType == "veggies"
                    || toppingType == "cheese" || toppingType == "sauce")
                {
                    this.type = value;
                }
                else
                {
                    string excMsgInvalidType =
                        string.Format(ExceptionMessages.InvalidTopping, value);

                    throw new ArgumentException(excMsgInvalidType);
                }
            }
        }

        private double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || 50 < value)
                {
                    string excMsgInvalidWeight = string.Format(ExceptionMessages.InvalidToppingWeight, this.Type);

                    throw new ArgumentException(excMsgInvalidWeight);
                }

                this.weight = value;
            }
        }

        private double MakeTopping()
        {
            if (this.Type.ToLower() == "meat")
            {
                return this.Weight * MEAT * BASE_CALLORIES_PER_GRAM;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                return this.Weight * VEGGIES * BASE_CALLORIES_PER_GRAM;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                return this.Weight * CHEESE * BASE_CALLORIES_PER_GRAM;
            }
            else if (this.Type.ToLower() == "sauce")
            {
                return this.Weight * SAUCE * BASE_CALLORIES_PER_GRAM;
            }

            return 0;
        }
    }
}
