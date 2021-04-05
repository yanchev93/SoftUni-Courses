namespace OnlineShop.Models.Products
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OnlineShop.Models.Products.Components;
    using OnlineShop.Models.Products.Computers;
    using OnlineShop.Models.Products.Peripherals;

    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        public Computer(int id, string manufacturer, string model,
            decimal price, double overallPerfomance)
            : base(id, manufacturer, model, price, overallPerfomance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public override double OverallPerformance
        {
            get
            {
                if (this.Components.Count == 0)
                {
                    return base.OverallPerformance;
                }

                double sumComponent = 0;
                foreach (var component in this.components)
                {
                    sumComponent += component.OverallPerformance;
                }

                double result = this.components.Select(x => x.OverallPerformance).Sum();
                result += base.OverallPerformance;

                return result;
            }
            protected set => base.OverallPerformance = value;
        }

        public override decimal Price
        {
            get
            {
                decimal result = base.Price;
                result += this.components.Select(x => x.Price).Sum();
                result += this.peripherals.Select(x => x.Price).Sum();

                return result;
            }
        }

        public IReadOnlyCollection<IComponent> Components
        {
            get
            {
                return this.components;
            }
        }

        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get
            {
                return this.peripherals;
            }
        }

        public void AddComponent(IComponent component)
        {
            throw new System.NotImplementedException();
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new System.NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            throw new System.NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})");
            sb.AppendLine($" Components ({this.components.Count}):");

            foreach (var component in this.components)
            {
                sb.AppendLine($"  {component.Model}");
            }

            sb.AppendLine($" Peripherals ({this.peripherals.Count}); Average Overall Performance ({this.peripherals.Select(x=>x.OverallPerformance).Average()}:");

            foreach (var peripheral in this.peripherals)
            {
                sb.AppendLine($"  {peripheral.Model}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
