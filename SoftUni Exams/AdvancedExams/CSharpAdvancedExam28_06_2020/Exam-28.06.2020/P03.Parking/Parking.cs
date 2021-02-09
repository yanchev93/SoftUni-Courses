namespace Parking
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Parking
    {
        private List<Car> data;
        public Parking()
        {
            this.data = new List<Car>();
        }
        public Parking(string type, int capacity)
            : this()
        {
            this.Type = type;
            this.Capacity = capacity;
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get { return this.data.Count; }
        }

        public void Add(Car car)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacterer, string model)
        {
            Car car = this.data.FirstOrDefault(c => c.Manufacturer == manufacterer && c.Model == model);

            if (car == null)
            {
                return false;
            }
            
            this.data.Remove(car);

            return true;
        }

        public Car GetLatestCar()
        {
            int latestYear = 0;

            foreach (Car currentCar in this.data)
            {
                if (latestYear < currentCar.Year)
                {
                    latestYear = currentCar.Year;
                }
            }

            Car car = this.data.FirstOrDefault(c => c.Year == latestYear);

            return car;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = this.data.FirstOrDefault(c => c.Manufacturer == manufacturer
                                                 && c.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (Car car in this.data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }  

    }
}
