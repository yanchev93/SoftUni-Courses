namespace OnlineShop.Models.Products
{
    public class Mouse : Peripheral
    {
        public Mouse(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, string connectionType)
            : base(id, manufacturer, model, price, overallPerfomance, connectionType)
        {
        }
    }
}
