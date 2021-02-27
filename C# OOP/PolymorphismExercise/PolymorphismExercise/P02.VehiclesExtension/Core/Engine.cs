namespace P02.VehiclesExtension.Core
{
    using System;
    using System.Linq;

    using Models;
    using Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            string[] inputCar = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            double carFuelQty = double.Parse(inputCar[1]);
            double carFuelConsumption = double.Parse(inputCar[2]);
            double carTankCapacity = double.Parse(inputCar[3]);

            Vehicle car = new Car(carFuelQty, carFuelConsumption, carTankCapacity);

            string[] inputTruck = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
            double truckFuelQty = double.Parse(inputTruck[1]);
            double truckFuelConsumption = double.Parse(inputTruck[2]);
            double trucktankCapacity = double.Parse(inputTruck[3]);

            Vehicle truck = new Truck(truckFuelQty, truckFuelConsumption, trucktankCapacity);

            string[] inputBus = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            double busFuelQty = double.Parse(inputBus[1]);
            double busFuelConsumption = double.Parse(inputBus[2]);
            double busTankCapacity = double.Parse(inputBus[3]);

            Vehicle bus = new Bus(busFuelQty, busFuelConsumption, busTankCapacity);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                try
                {
                    ProcessCommand(car, truck, bus, commands);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle car, Vehicle truck, Vehicle bus, string[] commands)
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
                else if (typeVehicle == "Bus")
                {
                    Console.WriteLine(bus.Drive(arguments));
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
                else if (typeVehicle == "Bus")
                {
                    bus.Refuel(arguments);
                }
            }
            else if (command == "DriveEmpty")
            {
                if (typeVehicle == "Bus")
                {
                    Console.WriteLine(((Bus)bus).DriveEmpty(arguments));
                }
            }
        }
    }
}
