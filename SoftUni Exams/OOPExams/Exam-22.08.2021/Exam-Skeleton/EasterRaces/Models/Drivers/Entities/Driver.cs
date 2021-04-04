namespace EasterRaces.Models.Drivers.Entities
{
    using System;

    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Drivers.Contracts;

    public class Driver : IDriver
    {
        private string name;
        private ICar car;
        private int numberOfWins;

        public Driver(string name)
        {
            this.Name = name;
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

        public ICar Car
        {
            get
            {
                return this.car;
            }
        }

        public int NumberOfWins
        {
            get
            {
                return this.numberOfWins;
            }
        }

        public bool CanParticipate
        {
            get
            {
                return this.Car != null;
            }
        }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                string exc = $"Car cannot be null.";

                throw new ArgumentNullException(nameof(ICar), exc);
            }

            this.car = car;
        }

        public void WinRace()
        {
            this.numberOfWins += 1;
        }
    }
}
