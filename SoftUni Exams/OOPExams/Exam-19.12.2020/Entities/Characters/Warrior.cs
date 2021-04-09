namespace WarCroft.Entities.Characters
{
    using System;
    using WarCroft.Constants;
    using WarCroft.Entities.Characters.Contracts;
    using WarCroft.Entities.Inventory;

    public class Warrior : Character, IAttacker
    {
        private const double BASE_HEALTH_WARRIOR = 100;
        private const double BASE_ARMOR_WARRIOR = 50;
        private const double ABILITY_POINTS = 40;

        public Warrior(string name)
            : base(name, BASE_HEALTH_WARRIOR, BASE_ARMOR_WARRIOR, ABILITY_POINTS, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            if (character.Name == this.Name)
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }

            character.TakeDamage(ABILITY_POINTS);
        }
    }
}
