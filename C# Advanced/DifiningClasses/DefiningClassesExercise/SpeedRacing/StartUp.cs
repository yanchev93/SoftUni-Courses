using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> carList = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] infoCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = infoCar[0];

                int engineSpeed = int.Parse(infoCar[1]);
                int enginePower = int.Parse(infoCar[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(infoCar[3]);
                string cargoType = infoCar[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];

                int count = 0;
                for (int tireStart = 5; tireStart < infoCar.Length; tireStart += 2)
                {
                    double tirePressure = double.Parse(infoCar[tireStart]);
                    int tireAge = int.Parse(infoCar[tireStart + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);

                    tires[count] = tire;
                    count += 1;
                }

                Car currentCar = new Car(model, cargo, engine, tires);

                carList.Add(currentCar);
            }

            string inputCargo = Console.ReadLine();

            if (inputCargo == "fragile")
            {
                foreach (Car car in carList.FindAll(c => c.Cargo.CargoType == "fragile"))
                {
                    bool isValid = false;
                    foreach (Tire tirePressure in car.Tires)
                    {
                        if (tirePressure.TirePressure < 1)
                        {
                            isValid = true;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (inputCargo == "flamable")
            {
                foreach (Car car in carList.FindAll((c => c.Cargo.CargoType == "flamable"
                && c.Engine.EnginePower > 250)))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
