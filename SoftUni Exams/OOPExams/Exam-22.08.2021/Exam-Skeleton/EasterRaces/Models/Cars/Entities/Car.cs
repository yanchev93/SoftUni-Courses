namespace EasterRaces.Models.Cars.Entities
{
    using System;

    using EasterRaces.Models.Cars.Contracts;

    public abstract class Car : ICar
    {
        private string model;
        private int horsePower;
        private double cubicCentimeters;
        private int minHorsePower;
        private int maxHorsePower;

        public Car(string model, int horsePower, double cubicCentimeters,
            int minHorsePower, int maxHorsePower)
        {
            this.Model = model;
            this.MinHorsePower = minHorsePower;
            this.MaxHorsePower = maxHorsePower;
            this.CubicCentimeters = cubicCentimeters;
            this.HorsePower = horsePower;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    string exc = $"Model {value} cannot be less than 4 symbols.";

                    throw new ArgumentException(exc);
                }

                this.model = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            private set
            {
                if (value < minHorsePower || maxHorsePower < value)
                {
                    string exc = $"Invalid horse power: {value}";

                    throw new ArgumentException(exc);
                }

                this.horsePower = value;
            }
        }

        public double CubicCentimeters
        {
            get
            {
                return this.cubicCentimeters;
            }
            private set
            {
                this.cubicCentimeters = value;
            }
        }

        public int MinHorsePower
        {
            get
            {
                return this.minHorsePower;
            }
            private set
            {
                this.minHorsePower = value;
            }
        }

        public int MaxHorsePower
        {
            get
            {
                return this.maxHorsePower;
            }
            private set
            {
                this.maxHorsePower = value;
            }
        }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}
