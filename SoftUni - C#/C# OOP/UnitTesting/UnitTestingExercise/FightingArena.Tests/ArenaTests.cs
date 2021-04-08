using System;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void Arena_Count()
        {
            Warrior deffender = new Warrior("Deffender", 50, 100);
            Warrior attacker = new Warrior("Attacker", 55, 100);
            Warrior warrior = new Warrior("Warrior", 45, 150);

            arena.Enroll(deffender);
            arena.Enroll(attacker);
            arena.Enroll(warrior);

            int expectedArenaCount = 3;
            int actualArenaCount = this.arena.Count;

            Assert.That(actualArenaCount, Is.EqualTo(expectedArenaCount));
        }

        [Test]
        public void Enroll_ThrowsInvalidOperationException_IfWarriorIsWithTheSameName()
        {
            Warrior attacker = new Warrior("Attacker", 50, 100);
            Warrior deffender = new Warrior("Attacker", 50, 125);

            this.arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(deffender));
        }

        [Test]
        public void Fight_ThrowsInvalidOperationException_IfNoWarriorWithThisName()
        {
            Warrior attacker = new Warrior("Attacker", 50, 100);
            Warrior deffender = new Warrior("Deffender", 30, 100);

            this.arena.Enroll(attacker);
            this.arena.Enroll(deffender);

            string attackerName = "Attacker";
            string deffenderName = "Deffendercho";

            Assert.Throws<InvalidOperationException>(() =>
            this.arena.Fight(attackerName, deffenderName));
        }
    }
}
