using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly DecorationRepository decorations;
        private readonly List<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;

            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.aquariums.Add(aquarium);

            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;

            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            this.decorations.Add(decoration);

            return $"Successfully added {decorationType}.";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            var decoration = this.decorations.FindByType(decorationType);

            if (decoration == null)
            {
                string exc = string.Format(ExceptionMessages.InexistentDecoration, decorationType);

                throw new InvalidOperationException(exc);
            }

            aquarium.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            
            IFish fish = null;
            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            if (aquarium.GetType().Name == "FreshwaterAquarium" && fishType == "FreshwaterFish")
            {
                aquarium.AddFish(fish);

                return $"Successfully added {fishType} to {aquariumName}.";
            }
            else if (aquarium.GetType().Name == "SaltwaterAquarium" && fishType == "SaltwaterFish")
            {
                aquarium.AddFish(fish);

                return $"Successfully added {fishType} to {aquariumName}.";
            }
            else
            {
                return $"Water not suitable.";
            }

        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            aquarium.Feed();
            var fedCount = aquarium.Fish.Count;

            return $"Fish fed: {fedCount}";
        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            decimal value = 0;

            foreach (var decoration in aquarium.Decorations)
            {
                value += decoration.Price;
            }

            foreach (var fish in aquarium.Fish)
            {
                value += fish.Price;
            }

            return $"The value of Aquarium {aquariumName} is {value:f2}.";
        }
        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in this.aquariums)
            {
                sb.AppendLine(aquarium.GetInfo()); // NB: Check for "none" !!!
            }

            return sb.ToString().TrimEnd();
        }
    }
}
