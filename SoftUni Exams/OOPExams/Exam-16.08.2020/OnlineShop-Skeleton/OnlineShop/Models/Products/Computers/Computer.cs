namespace OnlineShop.Models.Products
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

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
                if (this.components.Count == 0)
                {
                    return this.OverallPerformance;
                }

                double sumComponent = 0;
                foreach (var component in this.components)
                {
                    sumComponent += component.OverallPerformance;
                }

                sumComponent /= this.components.Count;
                // double result = this.components.Select(x => x.OverallPerformance).Sum();

                sumComponent += this.OverallPerformance;

                return sumComponent;
            }
            protected set
            {
                this.OverallPerformance = value;
            }
        }

        public override decimal Price
        {
            get
            {
                decimal result = this.Price;

                foreach (var component in this.components)
                {
                    result += component.Price;
                }

                foreach (var peripheral in this.peripherals)
                {
                    result += peripheral.Price;
                }

                return result;
            }
            protected set
            {
                this.Price = value;
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
            var compType = component.GetType().Name;

            var contains = this.components.Any(x => x.GetType().Name == compType);

            if (contains)
            {
                string exc = $"Component {component.GetType().Name} already exists in {this.Model} with Id {this.Id}.";

                throw new ArgumentException(exc);
            }

            this.components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            var perType = peripheral.GetType().Name;

            var contains = this.peripherals.Any(x => x.GetType().Name == perType);

            if (contains)
            {
                string exc = $"Peripheral {perType} already exists in {this.Model} with Id {this.Id}.";

                throw new ArgumentException(exc);
            }

            this.peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (this.components.Count == 0 || !this.components.Any(x => x.GetType().Name == componentType))
            {
                string exc = $"Component {componentType} does not exist in {this.Model} with Id {this.Id}.";

                throw new ArgumentException(exc);
            }

            var componentToRemove = this.components.FirstOrDefault(x => x.GetType().Name == componentType);

            this.components.Remove(componentToRemove);

            return componentToRemove;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (this.peripherals.Count == 0 || !this.peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                string exc = $"Peripheral {peripheralType} does not exist in {this.Model} with Id {this.Id}.";

                throw new ArgumentException(exc);
            }

            var perhipheralsToRemove = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            this.peripherals.Remove(perhipheralsToRemove);

            return perhipheralsToRemove;
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

            sb.AppendLine($" Peripherals ({this.peripherals.Count}); Average Overall Performance ({this.peripherals.Select(x => x.OverallPerformance).Average()}):");

            foreach (var peripheral in this.peripherals)
            {
                sb.AppendLine($"  {peripheral.Model}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
