namespace P01.Vehicles.Models
{
    using System;

    public class Car : Vehicle
    {
        private const double AIR_CONDITIONER_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + AIR_CONDITIONER_CONSUMPTION;
            }
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
        }
    }
}
