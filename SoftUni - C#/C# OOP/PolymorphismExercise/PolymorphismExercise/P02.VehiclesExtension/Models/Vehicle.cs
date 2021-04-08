namespace P02.VehiclesExtension.Models
{
    using System;
    using Common;
    using Contracts;

    public abstract class Vehicle : IDrivable, IRefuelable
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value <= 0)
                {
                    string excNegativeFuel = ExceptionMessages.NegativeFuel;

                    throw new InvalidOperationException(excNegativeFuel);
                }

                this.fuelQuantity = (value > this.TankCapacity) ? 0 : value;
            }
        }

        public virtual double FuelConsumption 
        { 
            get
            { 
                return this.fuelConsumption;
            }
            protected set
            {
                if (value <= 0)
                {
                    string excNegativeFuel = ExceptionMessages.NegativeFuel;

                    throw new InvalidOperationException(excNegativeFuel);
                }

                this.fuelConsumption = value;
            }
        }

        public virtual double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException(ExceptionMessages.NegativeFuel);
                }

                this.tankCapacity = value;

                if (this.FuelQuantity > this.tankCapacity)
                {
                    this.fuelQuantity = 0.0;
                }
            }
        }

        protected abstract double AirConditionerConsumption { get; }

        public virtual string Drive(double distance)
        {
            double fuelNeeded = this.FuelConsumption * distance;

            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            string excMsg = string.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name);

            throw new InvalidOperationException(excMsg);
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NegativeFuel);
            }
            else
            {
                double totalFuel = this.FuelQuantity + liters;

                if (totalFuel > this.TankCapacity)
                {
                    string excRefuelMsg =
                    string.Format(ExceptionMessages.TooMuchFuelToRefuel, liters);

                    throw new InvalidOperationException(excRefuelMsg);
                }

                this.FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
