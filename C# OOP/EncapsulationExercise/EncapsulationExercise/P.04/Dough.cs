using System;

namespace P04.PizzaCalories
{
    public class Dough
    {
        private const double WHITE = 1.5;

        private const double WHOLEGRAIN = 1.0;

        private const double CRISPY = 0.9;

        private const double CHEWY = 1.1;

        private const double HOMEMADE = 1.0;

        private string flourType;

        private string bakingTechnique;

        private double weight;

        private double caloriesPerGram => MakeDough();
        
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public double CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
        }

        private string FlourType
        {

            get
            {
                return this.flourType;
            }
            set
            {
                string flour = value.ToLower();

                if (flour == "white" || flour == "wholegrain")
                {
                    this.flourType = value;
                }
                else
                {
                    string excMsg = ExceptionMessages.InvalidDough;

                    throw new ArgumentException(excMsg);
                }
            }
        }

        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                string bakingTech = value.ToLower();

                if (bakingTech == "crispy" || bakingTech == "chewy" || bakingTech == "homemade")
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    string excMsg = ExceptionMessages.InvalidDough;

                    throw new ArgumentException(excMsg);
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
                if (value < 1 || 200 < value)
                {
                    string excMsg = ExceptionMessages.InvalidWeight;

                    throw new ArgumentException(excMsg);
                }

                this.weight = value;
            }
        }

        private double MakeDough()
        {
            double caloriesPerGram = 0;

            if (this.FlourType.ToLower() == "white")
            {
                return caloriesPerGram = WhiteBaking();
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                return caloriesPerGram = WholegrainBaking();
            }

            return 0;
        }

        private double WholegrainBaking()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return (2 * this.Weight) * WHOLEGRAIN * CRISPY;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return (2 * this.Weight) * WHOLEGRAIN * CHEWY;

            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                return (2 * this.Weight) * WHOLEGRAIN * HOMEMADE;
            }

            return 0;
        }

        private double WhiteBaking()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return (2 * this.Weight) * WHITE * CRISPY;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return (2 * this.Weight) * WHITE * CHEWY;

            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                return (2 * this.Weight) * WHITE * HOMEMADE;
            }

            return 0;
        }
    }
}
