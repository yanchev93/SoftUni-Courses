namespace WarCroft.Entities.Characters
{
    using System;
    using WarCroft.Constants;
    using WarCroft.Entities.Characters.Contracts;
    using WarCroft.Entities.Inventory;

    public class Priest : Character, IHealer
    {
        private const double BASE_HEALTH_PRIEST = 50;
        private const double BASE_ARMOR_PRIEST = 25;
        private const double ABILITY_POINTS = 40;


        public Priest(string name)
            : base(name, BASE_HEALTH_PRIEST, BASE_ARMOR_PRIEST, ABILITY_POINTS, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new ArgumentException(ExceptionMessages.AffectedCharacterDead);
            }

            character.Health += ABILITY_POINTS;
        }
    }
}
