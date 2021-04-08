using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tireList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();

            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                // int year = int.Parse(currentCommand[0]);
                // double pressure = double.Parse(currentCommand[1]);
                Tire[] tires = new Tire[4];

                int count = 0;
                for (int i = 0; i < currentCommand.Length; i += 2)
                {
                    int year = int.Parse(currentCommand[i]);
                    double pressure = double.Parse(currentCommand[i + 1]);

                    var tire = new Tire(year, pressure);

                    tires[count] = tire;

                    count += 1;
                }

                tireList.Add(tires);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(currentCommand[0]);
                double cubicCapacity = double.Parse(currentCommand[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                engineList.Add(engine);

                command = Console.ReadLine();
            }

            List<Car> carList = new List<Car>();

            command = Console.ReadLine();
            while (command != "Show special")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string make = currentCommand[0];
                string model = currentCommand[1];
                int year = int.Parse(currentCommand[2]);
                double fuelQuantity = double.Parse(currentCommand[3]);
                double fuelConsumption = double.Parse(currentCommand[4]);
                int engineIndex = int.Parse(currentCommand[5]);
                int tiresIndex = int.Parse(currentCommand[6]);

                var currentEngine = engineList[engineIndex];
                var currentTires = tireList[tiresIndex];

                Car currentCar = new Car(make, model, year,
                    fuelQuantity, fuelConsumption,
                    currentEngine, currentTires);

                carList.Add(currentCar);

                command = Console.ReadLine();
            }

            List<Car> specialCars = new List<Car>();

            foreach (Car car in carList)
            {
                double sumTiresPressure = 0;
                foreach (var tirePressure in car.Tires)
                {
                    sumTiresPressure += tirePressure.Pressure;
                }

                if ((2017 <= car.Year && 330 < car.Engine.HorsePower) &&
                    (9 <= sumTiresPressure && sumTiresPressure <= 10))
                {
                    car.Drive(20);

                    specialCars.Add(car);
                }
            }

            StringBuilder printCar = new StringBuilder();

            foreach (Car specialCar in specialCars)
            {
                printCar.AppendLine($"Make: {specialCar.Make}");
                printCar.AppendLine($"Model: {specialCar.Model}");
                printCar.AppendLine($"Year: {specialCar.Year}");
                printCar.AppendLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                printCar.AppendLine($"FuelQuantity: {specialCar.FuelQuantity:f1}");
            }

            Console.WriteLine(printCar);
        }
    }
}
