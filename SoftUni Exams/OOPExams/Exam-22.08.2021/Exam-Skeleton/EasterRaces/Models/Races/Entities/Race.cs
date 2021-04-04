namespace EasterRaces.Models.Races.Entities
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Models.Races.Contracts;

    public class Race : IRace
    {
        private string name;
        private int laps;
        private readonly List<IDriver> drivers;

        public Race(string name, int laps)
        {
            this.drivers = new List<IDriver>();

            this.Name = name;
            this.Laps = laps;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    string exc = $"Name {value} cannot be less than 5 symbols.";

                    throw new ArgumentException(exc);
                }

                this.name = value;
            }

        }
        public int Laps
        {
            get
            {
                return this.laps;
            }
            private set
            {
                if (value < 1)
                {
                    string exc = $"Laps cannot be less than 1.";

                    throw new ArgumentException(exc);
                }

                this.laps = value;
            }
        }
        public IReadOnlyCollection<IDriver> Drivers
        {
            get
            {
                return this.drivers;
            }
        }

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                string exc = "Driver cannot be null.";

                throw new ArgumentNullException(nameof(IDriver), exc);
            }

            if (!driver.CanParticipate)
            {
                string exc = $"Driver {driver.Name} could not participate in race.";

                throw new ArgumentException(exc);
            }

            if (this.drivers.Any(d => d.Name == driver.Name))
            {
                string exc = $"Driver {driver.Name} is already added in {this.Name} race.";

                throw new ArgumentNullException(nameof(IDriver), exc);
            }

            this.drivers.Add(driver);
        }
    }
}
