using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int WEIGHT = 5;

        public FirePotion()
            : base(WEIGHT)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                if (character.Health > 0)
                {
                    character.TakeDamage(20);
                }
            }
        }
    }
}
