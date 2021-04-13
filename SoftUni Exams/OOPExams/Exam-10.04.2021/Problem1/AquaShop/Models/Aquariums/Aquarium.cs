using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capacity;
        private readonly ICollection<IDecoration> decorations;
        private readonly ICollection<IFish> fishes;
        private int comfort; // readonly?

        //ctor
        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.decorations = new List<IDecoration>();
            this.fishes = new List<IFish>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }

                this.name = value;
            }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                this.capacity = value;
            }

        }

        public int Comfort
        {
            get
            {
                int sumDecoration = this.decorations.Sum(x => x.Comfort);

                this.comfort = sumDecoration;

                return this.comfort;
            }
        }

        public ICollection<IDecoration> Decorations
        {
            get
            {
                return this.decorations.ToList().AsReadOnly();
            }
        }

        public ICollection<IFish> Fish
        {
            get
            {
                return this.fishes.ToList().AsReadOnly();
            }
        }

        public void AddFish(IFish fish)
        {
            if (this.fishes.Count == this.capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            this.fishes.Add(fish);
        }

        public bool RemoveFish(IFish fish)
        {
            var fishToRemove = this.fishes.FirstOrDefault(x => x.Name == fish.Name);

            if (fishToRemove == null)
            {
                return false;
            }

            return this.fishes.Remove(fish);
        }

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void Feed()
        {
            foreach (IFish fish in this.fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            //if (!this.fishes.Any())
            //{
            //    return "none";
            //}

            StringBuilder sb = new StringBuilder();

            var fishString = this.fishes.Count == 0 ? "none" : string.Join(", ", this.fishes.Select(f => f.Name));

            sb.AppendLine($"{this.Name} ({this.GetType().Name}):")
              .AppendLine($"Fish: {fishString}")
              .AppendLine($"Decorations: {this.decorations.Count}")
              .AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();
        }
        
    }
}
