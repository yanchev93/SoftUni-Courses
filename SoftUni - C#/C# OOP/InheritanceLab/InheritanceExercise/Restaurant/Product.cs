using System.Text;

namespace Restaurant
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Product name: {this.Name}, Product price: {this.Price}")
                .AppendLine($"{GetType().Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
