using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string model = information[0];
                int engineSpeed = int.Parse(information[1]);
                int enginePower = int.Parse(information[2]);
                int cargoWeight = int.Parse(information[3]);
                string cargoType = information[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car currentCar = new Car(model, engine, cargo);

                carsList.Add(currentCar);

            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in carsList)
                {
                    if (car.Cargo.CargoType == "fragile" && car.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

            else if (command == "flamable")
            {
                foreach (Car car in carsList)
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }

        public class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }

            public Car(string model, Engine engine, Cargo cargo)
            {
                this.Model = model;
                this.Engine = engine;
                this.Cargo = cargo;
            }
        }

        public class Engine
        {
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }

            public Engine(int engineSpeed, int enginePower)
            {
                this.EngineSpeed = engineSpeed;
                this.EnginePower = enginePower;
            }
        }
        public class Cargo
        {
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }

            public Cargo(int cargoWeight, string cargoType)
            {
                this.CargoWeight = cargoWeight;
                this.CargoType = cargoType;
            }
        }
    }
}
