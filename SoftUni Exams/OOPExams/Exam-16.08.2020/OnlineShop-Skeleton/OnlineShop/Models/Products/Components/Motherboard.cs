namespace OnlineShop.Models.Products
{
    public class Motherboard : Component
    {
        private const double MULTIPLIER = 1.25;

        public Motherboard(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, int generation)
            : base(id, manufacturer, model, price, overallPerfomance, generation)
        {
            this.OverallPerformance = overallPerfomance * MULTIPLIER;
        }
    }
}
