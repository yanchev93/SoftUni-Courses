namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double COFFEE_MILLILITERS = 50;
        private const decimal COFFEE_PRICE = 3.50m;

        public Coffee(string name, double caffein)
            : base(name, COFFEE_PRICE, COFFEE_MILLILITERS)
        {
            this.Caffeine = caffein;
        }

        public double Caffeine { get; }
    }
}
