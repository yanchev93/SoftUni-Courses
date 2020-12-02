using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            Catalogue catalog = new Catalogue();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split();
                string type = currentCommand[0];
                string model = currentCommand[1];
                string color = currentCommand[2];
                double horsePower = double.Parse(currentCommand[3]);

                if (type == "car")
                {
                    Cars car = new Cars(model, color, horsePower);
                    catalog.carList.Add(car);
                }

                else if (type == "truck")
                {
                    Trucks truck = new Trucks(model, color, horsePower);
                    catalog.truckList.Add(truck);
                }

                command = Console.ReadLine();
            }

            double avrCarsHorsePower = 0.00;
            double avrTrucksHorsePower = 0.00;

            while (true)
            {
                command = Console.ReadLine();

                bool isCar = false;

                if (command == "Close the Catalogue")
                {
                    if (catalog.carList.Count > 0)
                    {
                        foreach (Cars car in catalog.carList)
                        {
                            avrCarsHorsePower += car.HorsePower;
                        }

                        avrCarsHorsePower /= Cars.CountCars;
                    }


                    if (catalog.truckList.Count > 0)
                    {
                        foreach (Trucks truck in catalog.truckList)
                        {
                            avrTrucksHorsePower += truck.HorsePower;
                        }

                        avrTrucksHorsePower /= Trucks.CountsTrucks;
                    }

                    Console.WriteLine($"Cars have average horsepower of: {avrCarsHorsePower:f2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {avrTrucksHorsePower:f2}.");

                    return;
                }

                else
                {
                    foreach (var car in catalog.carList)
                    {
                        if (command == car.Model)
                        {
                            Console.WriteLine($"Type: Car");
                            Console.WriteLine($"Model: {car.Model}");
                            Console.WriteLine($"Color: {car.Color}");
                            Console.WriteLine($"Horsepower: {car.HorsePower}");

                            isCar = true;
                            break;
                        }
                    }

                    foreach (var truck in catalog.truckList)
                    {
                        if (command == truck.Model)
                        {
                            Console.WriteLine($"Type: Truck");
                            Console.WriteLine($"Model: {truck.Model}");
                            Console.WriteLine($"Color: {truck.Color}");
                            Console.WriteLine($"Horsepower: {truck.HorsePower}");
                            break;
                        }

                        else if (isCar)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    public class Cars
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public static int CountCars { get; set; }

        public Cars(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;

            CountCars += 1;
        }
    }

    public class Trucks
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public static int CountsTrucks { get; set; }


        public Trucks(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;

            CountsTrucks += 1;
        }
    }

    public class Catalogue
    {
        public List<Cars> carList { get; set; }
        public List<Trucks> truckList { get; set; }

        public Catalogue()
        {
            this.carList = new List<Cars>();
            this.truckList = new List<Trucks>();
        }
    }
}
