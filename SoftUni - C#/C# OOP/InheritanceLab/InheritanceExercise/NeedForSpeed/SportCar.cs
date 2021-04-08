namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 10;

        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = DEFAULT_FUEL_CONSUMPTION;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
    }
}
