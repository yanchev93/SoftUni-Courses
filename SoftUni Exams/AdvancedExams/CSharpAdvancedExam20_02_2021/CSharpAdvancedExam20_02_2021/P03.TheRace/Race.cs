using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Racer racer)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(racer);
            }
        }
        public bool Remove(string name)
        {
            Racer racer = this.data.FirstOrDefault(r => r.Name == name);

            if (racer != null)
            {
                this.data.Remove(racer);

                return true;
            }

            return false;
        }
        public Racer GetOldestRacer()
        {
            int oldest = 0;

            foreach (var currentRacer in this.data)
            {
                if (currentRacer.Age > oldest)
                {
                    oldest = currentRacer.Age;
                }
            }

            Racer racer = this.data.FirstOrDefault(r => r.Age == oldest);

            return racer;
        }
        public Racer GetRacer(string name)
        {
            Racer racer = this.data.FirstOrDefault(r => r.Name == name);

            return racer;
        }
        public Racer GetFastestRacer()
        {
            Racer racer = null;
            int fastestCar = 0;

            foreach (var currentRacer in this.data)
            {
                if (fastestCar < currentRacer.Car.Speed)
                {
                    fastestCar = currentRacer.Car.Speed;
                }
            }

            racer = this.data.FirstOrDefault(r => r.Car.Speed == fastestCar);

            return racer;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {this.Name}:");

            foreach (var racer in this.data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
