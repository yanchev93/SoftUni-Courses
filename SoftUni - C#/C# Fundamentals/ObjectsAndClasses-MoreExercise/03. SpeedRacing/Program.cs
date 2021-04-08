using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int carsAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsAmount; i++)
            {
                string[] car = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string model = car[0];
                int fuel = int.Parse(car[1]);
                double consumption = double.Parse(car[2]);

                Car currentCar = new Car(model, fuel, consumption);
                cars.Add(currentCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] currentCommand = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                string drive = currentCommand[0];
                string model = currentCommand[1];
                int driveKM = int.Parse(currentCommand[2]);

                if (cars.Any(m => m.Model == model))
                {
                    var car = cars.FindIndex(m=>m.Model == model);
                    var curCar = cars[car];

                    curCar.Distance(curCar, driveKM);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public class Car
        {
            public string Model { get; set; }
            public double Fuel { get; set; }
            public double ConsumptionPerKM { get; set; }
            public int TraveledDistance { get; set; }

            public Car(string model, int fuel, double consumption)
            {
                this.Model = model;
                this.Fuel = fuel;
                this.ConsumptionPerKM = consumption;
                this.TraveledDistance = 0;
            }

            public void Distance(Car car, int driveKM)
            {
                double differenceL = driveKM * car.ConsumptionPerKM;
                if (car.Fuel >= differenceL)
                {
                    car.Fuel -= differenceL;
                    car.TraveledDistance += driveKM;
                }

                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            public override string ToString()
            {
                return $"{Model} {Fuel:f2} {TraveledDistance}";
            }
        }
    }
}
