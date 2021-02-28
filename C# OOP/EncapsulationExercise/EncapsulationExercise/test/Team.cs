namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;

        private double rating => this.players.Count > 0 ? RatingCalculation() : 0;

        private readonly List<Player> players;

        public Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name) : this()
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    string excName = "A name should not be empty.";

                    throw new ArgumentException(excName);
                }

                this.name = value;
            }
        }

        public double Rating
        {
            get
            {
                return this.rating;
            }
        }

        public void Add(Player player)
        {
            this.players.Add(player);
        }

        public void Remove(string playerName, string teamName)
        {
            Player removePlayer = this.players.FirstOrDefault(p => p.Name == playerName);

            if (removePlayer != null)
            {
                this.players.Remove(removePlayer);
            }
            else
            {
                string excRemove = $"Player {playerName} is not in {teamName} team.";

                throw new ArgumentException(excRemove);
            }
        }
        private double RatingCalculation()
        {
            double avrRating = 0.0;

            foreach (Player player in this.players)
            {
                avrRating += player.Endurance + player.Sprint + player.Dribble + player.Passing + player.Shooting;

                avrRating /= 5;
            }

            return avrRating / this.players.Count;
        }

        public override string ToString()
        {
            return $"{this.Name} - {Math.Round(this.Rating, MidpointRounding.AwayFromZero)}";
        }
    }
}
