namespace P02.VehiclesExtension.Models
{

    public class Truck : Vehicle
    {
        private const double TRUCK_EFFIEICNCY_PERCENTAGE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
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
                base.FuelConsumption = value + AirConditionerConsumption;
            }
        }

        public override double TankCapacity
        { 
            get => base.TankCapacity;
            protected set => base.TankCapacity = value * TRUCK_EFFIEICNCY_PERCENTAGE;
        }

        protected override double AirConditionerConsumption => 1.6;
    }
}
