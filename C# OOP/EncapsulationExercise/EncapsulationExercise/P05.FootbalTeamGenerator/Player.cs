namespace P05.FootballTeamGenerator
{
    using System;

    using P05.FootballTeamGenerator.Contracts;

    public class Player : IStats
    {
        private string name;

        private int endurance;

        private int sprint;

        private int dribble;

        private int passing;

        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
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

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                StatException(value, nameof(this.Endurance));

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                StatException(value, nameof(this.Sprint));

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                StatException(value, nameof(this.Dribble));

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                StatException(value, nameof(this.Passing));

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                StatException(value, nameof(this.Shooting));

                this.shooting = value;
            }
        }

        private void StatException(int value, string nameStat)
        {
            if (value < 0 || 100 < value)
            {
                string excStatMsg =
                    string.Format(FootballExceptions.StatException, nameStat);

                throw new ArgumentException(excStatMsg);
            }
        }
    }
}
