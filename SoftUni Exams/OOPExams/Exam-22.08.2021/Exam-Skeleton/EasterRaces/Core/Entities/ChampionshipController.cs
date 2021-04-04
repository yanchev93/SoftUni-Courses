namespace EasterRaces.Core.Entities
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using EasterRaces.Core.Contracts;
    using EasterRaces.Repositories.Entities;
    using EasterRaces.Repositories.Contracts;
    using EasterRaces.Models.Drivers.Entities;
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Cars.Entities;
    using EasterRaces.Models.Races.Contracts;
    using EasterRaces.Models.Races.Entities;
    using System.Text;

    public class ChampionshipController : DriverRepository, IChampionshipController
    {
        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            this.driverRepository = new DriverRepository();
            this.carRepository = new CarRepository();
            this.raceRepository = new RaceRepository();
        }

        public string CreateDriver(string driverName)
        {
            var driverExist = this.driverRepository.GetByName(driverName);

            if (driverExist != null)
            {
                string exc = $"Driver {driverName} is already created.";

                throw new ArgumentException(exc);
            }

            var driver = new Driver(driverName);
            this.driverRepository.Add(driver);

            return $"Driver {driverName} is created.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            var carExists = this.carRepository.GetByName(model);
            if (carExists != null)
            {
                string exc = $"Car {model} is already created.";

                throw new ArgumentException(exc);
            }

            ICar car = null;
            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            this.carRepository.Add(car);
            return $"{car.GetType().Name} {model} is created.";
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            var driver = this.driverRepository.GetByName(driverName);
            var car = this.carRepository.GetByName(carModel);

            if (driver == null)
            {
                string exc = $"Driver {driverName} could not be found.";

                throw new InvalidOperationException(exc);
            }

            if (car == null)
            {
                string exc = $"Car {carModel} could not be found.";

                throw new InvalidOperationException(exc);
            }

            driver.AddCar(car);
            this.carRepository.Remove(car); // check if errors. Not sure. Nothing said about this in the bussines logic part.

            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var driver = this.driverRepository.GetByName(driverName);
            var race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                string exc = $"Race {raceName} could not be found.";

                throw new InvalidOperationException(exc);
            }

            if (driver == null)
            {
                string exc = $"Driver {driverName} could not be found.";

                throw new InvalidOperationException(exc);
            }

            race.AddDriver(driver);
            // this.driverRepository.Remove(driver); // if errors, see if driver is removed will work.

            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateRace(string name, int laps)
        {
            var raceExists = this.raceRepository.GetByName(name);
            if (raceExists != null)
            {
                string exc = $"Race {name} is already create.";

                throw new InvalidOperationException(exc);
            }

            var race = new Race(name, laps);
            this.raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            var race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                string exc = $"Race {raceName} could not be found.";

                throw new InvalidOperationException(exc);
            }

            var raceDrivers = race.Drivers;

            if (raceDrivers.Count < 3)
            {
                string exc = $"Race {raceName} cannot start with less than 3 participants.";

                throw new InvalidOperationException(exc);
            }

            var sorted = raceDrivers.OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps)).ToArray();

            StringBuilder sb = new StringBuilder();

            string firstName = sorted[0].Name;
            string secondName = sorted[1].Name;
            string thirdName = sorted[2].Name;
            sb.AppendLine($"Driver {firstName} wins {raceName} race.")
              .AppendLine($"Driver {secondName} is second in {raceName} race.")
              .AppendLine($"Driver {thirdName} is third in {raceName} race.");

            this.raceRepository.Remove(race);

            string output = sb.ToString().TrimEnd();

            return output;
        }
    }
}
