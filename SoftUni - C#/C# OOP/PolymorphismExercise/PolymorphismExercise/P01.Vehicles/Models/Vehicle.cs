namespace P01.Vehicles.Models
{ 
    using System;
    using Common;
    using Contracts;

    public abstract class Vehicle : IDrivable, IRefuelable
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; protected set; }

        public string Drive(double distance)
        {
            double  fuelNeeded = this.FuelConsumption * distance;

            if (fuelNeeded < this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            string excMsg = string.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name);

            throw new InvalidOperationException(excMsg);
        }

        public virtual void Refuel(double liters)
        {
            if (liters > 0)
            {
                this.FuelQuantity += liters;

            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
