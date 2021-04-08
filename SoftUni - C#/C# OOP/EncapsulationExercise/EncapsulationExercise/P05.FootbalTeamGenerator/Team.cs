namespace P05.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private readonly List<Player> players;

        private string name;

        private int rating => this.NumberOfPlayers > 0 ? ExtractRating() : 0;

        public Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            : this()
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
                    string excName = FootballExceptions.NameException;

                    throw new ArgumentException(excName);
                }

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                return this.rating;
            }
            private set
            {
                ExtractRating();
            }
        }

        private int ExtractRating()
        {
            double ratingTeam = 0.0;
            foreach (var player in players)
            {
                double avrRatingPlayer = (player.Endurance + player.Sprint + player.Dribble + player.Passing + player.Shooting) / 5.0;

                ratingTeam += avrRatingPlayer;
            }

            ratingTeam /= this.NumberOfPlayers;

            double rounded = Math.Round(ratingTeam, MidpointRounding.AwayFromZero);

            int result = int.Parse(rounded.ToString());

            return result;
        }

        private int NumberOfPlayers
        {
            get
            {
                return this.players.Count;
            }
        }

        private IReadOnlyCollection<Player> Players
        {
            get
            {
                return this.players.AsReadOnly();
            }
        }

        public void Add(string name, Player player)
        {
            if (this.Name == name)
            {
                this.players.Add(player);
            }
            else
            {
                string excTeamName = 
                    string.Format(name, FootballExceptions.InvalidTeam);

                throw new ArgumentException(excTeamName);
            }
        }

        public void Remove(string name)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == name);

            if (playerToRemove == null)
            {
                string excRemovePlayer = string.Format(FootballExceptions.InvalidRemovePlayerException, name, this.Name);

                throw new ArgumentException(excRemovePlayer);
            }
            else
            {
                this.players.Remove(playerToRemove);
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
