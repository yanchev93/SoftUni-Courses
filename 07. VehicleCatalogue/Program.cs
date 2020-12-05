using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = currentCommand[0];
                string brand = currentCommand[1];
                string model = currentCommand[2];
                int definition = int.Parse(currentCommand[3]);

                if (type == "Car")
                {
                    Car currentCar = new Car(brand, model, definition);
                    catalog.Cars.Add(currentCar);
                }

                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck(brand, model, definition);
                    catalog.Trucks.Add(currentTruck);
                }

                command = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsePower;
            }
        }

        public class Catalog
        {
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
    }
}
