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
        protected double health;
        private double armor;
        private Bag bag;

        public Character(string name, double health, double armor,
            double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.Health = health;
            this.BaseHealth = health;
            this.Armor = armor;
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

        public double BaseHealth { get; private set; }

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value > 0)
                {
                    this.health = value;
                }
            }
        }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value > 0)
                {
                    this.armor = this.BaseArmor;
                }
            }
        }

        public virtual double AbilityPoints { get; private set; }

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

        public bool IsAlive { get; set; } = true;

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            if (this.Armor < hitPoints)
            {
                hitPoints -= this.Armor;
                this.armor = 0;

                if (this.Health > hitPoints)
                {
                    this.Health -= hitPoints;
                }
                else
                {
                    this.health = 0;
                    this.IsAlive = false;
                }
            }
            else
            {
                this.armor -= hitPoints;
            }
        }

        public void UseItem(Item item)
        {
            this.EnsureAlive();

            // Check if I have to see the bag of this.Character(warrior || priest). NOT SURE
            item.AffectCharacter(this);
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