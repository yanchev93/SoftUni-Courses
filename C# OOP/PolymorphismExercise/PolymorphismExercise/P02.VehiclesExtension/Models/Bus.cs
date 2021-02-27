namespace P02.VehiclesExtension.Models
{

    using System;
    using Common;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AirConditionerConsumption => 1.4;

        public override string Drive(double distance)
        {
            double fuelNeeded = (this.FuelConsumption + AirConditionerConsumption) * distance;

            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            string excMsg = string.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name);

            throw new InvalidOperationException(excMsg);
        }

        public string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }
    }
}
