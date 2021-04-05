namespace OnlineShop.Models.Products
{
    public class Headset : Peripheral
    {
        public Headset(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerfomance, connectionType)
        {
        }
    }
}
