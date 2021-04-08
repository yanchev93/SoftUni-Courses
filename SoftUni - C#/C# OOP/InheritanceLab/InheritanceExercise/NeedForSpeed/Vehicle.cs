namespace NeedForSpeed
{
    public class Vehicle
    {
        public const double fuelConsumptionVehicle = 1.25;

        private int horsePower;
        private double fuel;
        private double defaultFuelConsumption;
        private double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = fuelConsumptionVehicle;
            this.FuelConsumption = DefaultFuelConsumption;
        }

        public double DefaultFuelConsumption
        {
            get { return this.defaultFuelConsumption; }
            set { this.defaultFuelConsumption = value; }
        }
        public virtual double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
