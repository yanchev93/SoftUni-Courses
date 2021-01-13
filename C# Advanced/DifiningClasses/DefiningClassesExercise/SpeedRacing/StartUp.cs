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
                string[] currentCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelConsumptionForOneKm = double.Parse(currentCar[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionForOneKm);
                carList.Add(car);
            }

            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] currentCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string instruction = currentCommand[0];
                string carModel = currentCommand[1];
                double amountOfKm = double.Parse(currentCommand[2]);

                if (instruction != "Drive")
                {
                    command = Console.ReadLine();
                    continue;
                }

                Car driveCar = carList.Find(c => c.Model == carModel);

                driveCar.DriveCar(driveCar, amountOfKm);

                command = Console.ReadLine();
            }

            foreach (Car car in carList)
            {
                string carModel = car.Model;
                double carFuelAmount = car.FuelAmount;
                double carDistanceTraveled = car.TravelledDistance;
                Console.WriteLine($"{carModel} {carFuelAmount:f2} {carDistanceTraveled}");
            }

        }
    }
}
