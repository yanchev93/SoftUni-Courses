namespace P01.Vehicles.Core
{
    using System;
    using System.Linq;

    using Contracts;
    using Models;

    public class Engine : IEngine
    {
        public void Run()
        {
            string[] inputCar = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            double carFuelQuantity = double.Parse(inputCar[1]);
            double carFuelConsumption = double.Parse(inputCar[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);

            string[] inputTruck = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
            double truckFuelQuantity = double.Parse(inputTruck[1]);
            double truckFuelConsumption = double.Parse(inputTruck[2]);

            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                try
                {
                    ProcessCommand(car, truck, commands);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ProcessCommand(Vehicle car, Vehicle truck, string[] commands)
        {
            string command = commands[0];
            string typeVehicle = commands[1];
            double arguments = double.Parse(commands[2]);

            if (command == "Drive")
            {
                if (typeVehicle == "Car")
                {
                    Console.WriteLine(car.Drive(arguments));
                }
                else if (typeVehicle == "Truck")
                {
                    Console.WriteLine(truck.Drive(arguments));
                }
            }
            else if (command == "Refuel")
            {
                if (typeVehicle == "Car")
                {
                    car.Refuel(arguments);
                }
                else if (typeVehicle == "Truck")
                {
                    truck.Refuel(arguments);
                }
            }
        }
    }
}
