using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> aCollectionOfPokemon = new List<Pokemon>();
        private int appearance;

        public Trainer(string name, int numberOfBadges, int appearance)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
            this.Appearance = appearance;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }

        public List<Pokemon> ACollectionOfPokemon
        {
            get { return this.aCollectionOfPokemon; }
            set { this.aCollectionOfPokemon = value; }
        }

        public int Appearance
        {
            get { return this.appearance; }
            set { this.appearance = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.aCollectionOfPokemon.Add(pokemon);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .Append($"{this.Name} {this.NumberOfBadges} {this.ACollectionOfPokemon.Count}");

            return sb.ToString().TrimEnd();
        }
    }
}
