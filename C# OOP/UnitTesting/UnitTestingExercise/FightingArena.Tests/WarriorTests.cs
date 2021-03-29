using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;

        [SetUp]
        public void Setup()
        {
            string name = "Warrior";
            int damage = 50;
            int hp = 30;

            this.warrior = new Warrior(name, damage, hp);
        }

        [Test]
        [TestCase("    ", 50, 100)]
        [TestCase(null, 50, 100)]
        [TestCase("Warrior", 0, 100)]
        [TestCase("Warrior", -20, 100)]
        [TestCase("Warrior", 50, -20)]
        public void Ctor_ThrowsArgumentException(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(name, damage, hp));
        }

        [Test]
        public void Ctor_SetTheWarriorValues()
        {
            string name = "Warrior";
            int damage = 50;
            int hp = 30;

            Assert.That(this.warrior.Name, Is.EqualTo(name));
            Assert.That(this.warrior.Damage, Is.EqualTo(damage));
            Assert.That(this.warrior.HP, Is.EqualTo(hp));
        }

        [Test]
        public void Attacker_ShouldThrowInvalidOperationException()
        {
            Warrior attacker = new Warrior("Attacker", 50, 25);
            Warrior deffender = new Warrior("Defender", 30, 100);

            Assert.Throws<InvalidOperationException>(
                () => attacker.Attack(deffender));
        }

        [Test]
        public void Defender_ShouldThrowInvalidOperationException()
        {
            Warrior deffender = new Warrior("Defender", 30, 30);

            Assert.Throws<InvalidOperationException>(
                () => this.warrior.Attack(deffender));
        }

        [Test]
        public void Defender_ShouldThrowInvalidOperationException_IfDefenderDamageIsBigger()
        {
            Warrior attacker = new Warrior("Attacker", 50, 50);
            Warrior deffender = new Warrior("Defender", 60, 30);

            Assert.Throws<InvalidOperationException>(
                () => attacker.Attack(deffender));
        }

        [Test]
        public void Attacker_DecreaseHpToTheDefender()
        {
            Warrior attacker = new Warrior("Attacker", 50, 100);
            Warrior deffender = new Warrior("Deffender", 35, 100);

            attacker.Attack(deffender);

            int expectedAttackerHp = 65;
            int actualAttackerHp = attacker.HP;
            int expectedDeffenderHp = 50;
            int actualDeffenderHp = deffender.HP;

            Assert.That(actualAttackerHp, Is.EqualTo(expectedAttackerHp));
            Assert.That(actualDeffenderHp, Is.EqualTo(expectedDeffenderHp));
        }

        [Test]
        public void Attack_SetSecondWarriorHpToZero()
        {
            Warrior attacker = new Warrior("Attacker", 60, 100);
            Warrior defender = new Warrior("Defender", 50, 55);

            attacker.Attack(defender);
            int expectedDefenderHp = 0;
            int actualDefenderHp = defender.HP;

            Assert.That(actualDefenderHp, Is.EqualTo(expectedDefenderHp));
        }
    }
}