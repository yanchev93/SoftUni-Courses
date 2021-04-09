namespace WarCroft.Entities.Characters.Contracts
{
    using System;
    using System.Collections.Generic;

    using WarCroft.Constants;
    using WarCroft.Entities.Inventory;
    using WarCroft.Entities.Items;

    public abstract class Character
    {
        // TODO: Implement the rest of the class.

        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;

        public Character(string name, double health, double armor,
            double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.BaseArmor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
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
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        public double BaseHealth
        {
            get
            {
                return this.baseHealth;
            }
            private set
            {
                this.baseHealth = value;
                this.health = this.BaseHealth;
            }
        }

        public double Health
        {
            get
            {
                if (this.health < 0)
                {
                    this.health = 0;
                }

                return this.health;
            }
            set
            {
                if (this.health + value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                }
                else
                {
                    this.health += value;
                }
            }
        }

        public double BaseArmor
        {
            get
            {
                return this.baseArmor;
            }
            private set
            {
                this.baseArmor = value;
            }
        }

        public double Armor
        {
            get
            {
                if (this.armor < 0)
                {
                    this.armor = 0;
                }

                return this.armor;
            }
            private set
            {
                this.armor = this.BaseArmor;
            }
        }

        public virtual double AbilityPoints
        {
            get { return this.abilityPoints; }
            private set { this.abilityPoints = value; }
        }

        public Bag Bag
        {
            get
            {
                return this.bag;
            }
            private set
            {
                this.bag = value;
            }
        }

        public bool IsAlive
        {
            get;
            private set;
        } = true;

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            this.Armor -= hitPoints;

            var leftPointsForAttack = this.Armor * -1;

            if (this.Armor == 0 && leftPointsForAttack > 0)
            {
                this.health -= leftPointsForAttack;
            }

            if (this.Health == 0)
            {
                this.IsAlive = false;
            }
        }

        public void UseItem(Item item)
        {
            this.EnsureAlive();

            if (item.GetType().Name == "HealthPotion")
            {
                this.Health += 20;
            }
            else if (item.GetType().Name == "FirePotion")
            {
                var hitPoints = 20;

                this.TakeDamage(hitPoints);
            }
        }

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

    }
}