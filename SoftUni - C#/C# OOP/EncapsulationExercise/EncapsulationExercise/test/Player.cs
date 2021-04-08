using System;

namespace test
{
    public class Player
    {
        private string name;

        private int endurance;

        private int sprint;

        private int dribble;

        private int passing;

        private int shooting;

        public Player(string name, int endurance, int sprint,
                        int dribble, int passing, int shooting)
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
                    string excName = "A name should not be empty.";

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
                StatException(value, nameof(Endurance));

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
                StatException(value, nameof(Sprint));

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
                StatException(value, nameof(Dribble));

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
                StatException(value, nameof(Passing));

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
                StatException(value, nameof(Shooting));

                this.shooting = value;
            }
        }

        private void StatException(int value, string name)
        {
            if (value < 0 || 100 < value)
            {
                string excStat = $"{name} should be between 0 and 100.";

                throw new ArgumentException(excStat);
            }
        }
    }
}
