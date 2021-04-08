namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 8;

        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = DEFAULT_FUEL_CONSUMPTION;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
    }
}
