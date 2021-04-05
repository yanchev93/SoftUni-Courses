namespace OnlineShop.Models.Products
{
    using OnlineShop.Models.Products.Components;

    public abstract class Component : Product, IComponent
    {
        private int generation;

        protected Component(int id, string manufacturer, string model,
            decimal price, double overallPerfomance, int generation)
            : base(id, manufacturer, model, price, overallPerfomance)
        {
            this.Generation = generation;
        }

        public int Generation
        {
            get
            {
                return this.generation;
            }
            private set
            {
                this.generation = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id}) Generation: {this.Generation}";
        }

    }
}
