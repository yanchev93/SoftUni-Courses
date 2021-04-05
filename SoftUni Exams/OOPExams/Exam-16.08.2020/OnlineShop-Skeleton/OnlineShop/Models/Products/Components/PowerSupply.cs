namespace OnlineShop.Models.Products
{
    public class PowerSupply : Component
    {
        private const double MULTIPLIER = 1.05;

        public PowerSupply(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, int generation)
            : base(id, manufacturer, model, price, overallPerfomance, generation)
        {
            this.OverallPerformance = overallPerfomance * MULTIPLIER;
        }
    }
}
