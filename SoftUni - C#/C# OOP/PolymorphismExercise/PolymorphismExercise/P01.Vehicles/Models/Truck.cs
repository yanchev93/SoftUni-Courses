namespace P01.Vehicles.Models
{
    using System;

    public class Truck : Vehicle
    {
        private const double AIR_CONDITIONER_CONSUMPTION = 1.6;
        private const double TRUCK_EFFIEICNCY_PERCENTAGE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
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
            base.Refuel(liters * TRUCK_EFFIEICNCY_PERCENTAGE);
        }
    }
}
