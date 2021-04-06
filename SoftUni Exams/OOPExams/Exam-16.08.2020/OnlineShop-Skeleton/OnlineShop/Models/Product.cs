
namespace OnlineShop.Models.Products
{
    using System;

    public abstract class Product : IProduct
    {
        private int id;
        private string manufacturer;
        private string model;
        private decimal price;
        private double overallPerfomance;

        protected Product(int id, string manufacturer, string model,
            decimal price, double overallPerfomance)
        {
            this.Id = id;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.OverallPerformance = overallPerfomance;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value <= 0)
                {
                    string exc = $"Id can not be less or equal than 0.";

                    throw new ArgumentException(exc);
                }

                this.id = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    string exc = $"Manufacturer can not be empty.";

                    throw new ArgumentNullException(nameof(this.Manufacturer), exc);
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    string exc = $"Model can not be empty.";

                    throw new ArgumentNullException(nameof(this.Model), exc);
                }

                this.model = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value <= 0m)
                {
                    string exc = $"Price can not be less or equal than 0.";

                    throw new ArgumentException(exc);
                }

                this.price = value;
            }
        }

        public virtual double OverallPerformance
        {
            get
            {
                return this.overallPerfomance;
            }
            protected set
            {
                if (value <= 0)
                {
                    string exc = $"Overall Performance can not be less or equal than 0.";

                    throw new ArgumentException(exc);
                }

                this.overallPerfomance = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})";
        }
    }
}
