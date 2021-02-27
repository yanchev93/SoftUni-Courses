namespace P02.VehiclesExtension.Models
{

    public class Car : Vehicle
    {
        // private const double AIR_CONDITIONER_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
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

        protected override double AirConditionerConsumption => 0.9;
    }
}
