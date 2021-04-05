namespace OnlineShop.Models.Products
{
    using OnlineShop.Models.Products.Peripherals;

    public abstract class Peripheral : Product, IPeripheral
    {
        private string connectionType;

        protected Peripheral(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, string connectionType)
            : base(id, manufacturer, model, price, overallPerfomance)
        {
            this.ConnectionType = connectionType;
        }

        public string ConnectionType
        {
            get
            {
                return this.connectionType;
            }
            private set
            {
                this.connectionType = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id}) Connection Type: {this.ConnectionType}";
        }
    }
}
