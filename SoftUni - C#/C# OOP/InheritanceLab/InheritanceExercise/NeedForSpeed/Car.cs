namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = DEFAULT_FUEL_CONSUMPTION;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
    }
}
