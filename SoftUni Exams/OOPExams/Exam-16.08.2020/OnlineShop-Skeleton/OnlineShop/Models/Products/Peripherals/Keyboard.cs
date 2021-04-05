namespace OnlineShop.Models.Products
{
    public class Keyboard : Peripheral
    {
        public Keyboard(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerfomance, connectionType)
        {
        }
    }
}
