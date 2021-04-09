using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private readonly List<Character> characters;
        private readonly List<Item> items;

        public WarController()
        {
            this.characters = new List<Character>();
            this.items = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string characterType = args[0];
            string name = args[1];


            Character character = null;
            if (characterType == "Warrior")
            {
                character = new Warrior(name);
            }
            else if (characterType == "Priest")
            {
                character = new Priest(name);
            }
            else
            {
                throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }

            this.characters.Add(character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];


            Item item = null;
            if (itemName == "HealthPotion")
            {
                item = new HealthPotion();
            }
            else if (itemName == "FirePotion")
            {
                item = new FirePotion();
            }
            else
            {
                throw new ArgumentException($"Invalid item \"{itemName}\"!");
            }

            this.items.Add(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            var character = this.characters.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (this.items.Count == 0)
            {
                throw new InvalidOperationException($"No items left in pool!");
            }


            Item itemToBePicked = this.items.Last();
            character.Bag.AddItem(itemToBePicked);

            // Should I remove the item from the pool. Check for errors

            return $"{characterName} picked up {itemToBePicked.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            var character = this.characters.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            var item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return $"{characterName} used {item.GetType().Name}.";
        }

        public string GetStats()
        {
            var sortedCharacters = this.characters.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health);

            StringBuilder sb = new StringBuilder();

            foreach (var character in sortedCharacters)
            {
                var characterIsAlive = character.IsAlive ? "Alive" : "Dead";

                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {characterIsAlive}");
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            var attacker = this.characters.FirstOrDefault(x => x.Name == attackerName);
            var receiver = this.characters.FirstOrDefault(x => x.Name == receiverName);

            if (attacker == null)
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }
            else if (receiver == null)
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            if (attacker.GetType().Name == "Priest")
            {
                throw new ArgumentException($"{attackerName} cannot attack!");
            }

            StringBuilder sb = new StringBuilder();

            var attack = (Warrior)attacker;
            attack.Attack(receiver);

            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                sb.AppendLine($"{receiverName} is dead!");
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            var healer = this.characters.FirstOrDefault(x => x.Name == healerName);
            var receiver = this.characters.FirstOrDefault(x => x.Name == healingReceiverName);

            if (healer == null)
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }
            else if (receiver == null)
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }

            if (healer.GetType().Name == "Warrior")
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            IHealer currHealer = (IHealer)healer;
            currHealer.Heal(receiver);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!");

            return sb.ToString().TrimEnd();
        }
    }
}
