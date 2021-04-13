namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AquariumsTests
    {
        [Test]
        public void Name_Null()
        {
            Fish fish = new Fish("Pesho");

            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aquarium = new Aquarium(null, 1);
            });
        }

        [Test]
        public void Name_Work()
        {
            Fish fish = new Fish("Pesho");

            Aquarium aquarium = new Aquarium("Ribki", 1);

            var actual = aquarium.Name;
            var expected = "Ribki";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Capacity_LessThan0()
        {
            Fish fish = new Fish("Pesho");

            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aquarium = new Aquarium("Ribki", -1);
            });
        }

        [Test]
        public void Capacity_Work()
        {
            Fish fish = new Fish("Pesho");

            Aquarium aquarium = new Aquarium("Ribki", 3);

            var actual = aquarium.Capacity;
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Aquarium_AddThrows()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");
            Fish fish5 = new Fish("throw");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.Add(fish5);
            });
        }

        [Test]
        public void Aquarium_AddWork()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);

            var actual = aquarium.Count;
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Aquarium_RemoveThrowNull()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);


            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.RemoveFish(null);
            });
        }

        [Test]
        public void Aquarium_RemoveWorks()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);

            aquarium.RemoveFish("Pesho");

            var actualCount = aquarium.Count;
            var expectedCount = 3;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Aquarium_SellFishThrows()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.SellFish(null);
            });
        }

        [Test]
        public void Aquarium_SellFishWorks()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);

            var fish = aquarium.SellFish("Pesho");
            var expectedFish = "Pesho";

            Assert.AreEqual(expectedFish, fish.Name);
        }

        [Test]
        public void Aquarium_SellFishWorks2()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);
            aquarium.Add(fish3);
            aquarium.Add(fish4);

            var fish = aquarium.SellFish("Pesho");
            var expectedAvailable = false;

            Assert.AreEqual(expectedAvailable, fish.Available);
        }

        [Test]
        public void Aquarium_Report()
        {
            Aquarium aquarium = new Aquarium("Ribki", 4);

            Fish fish1 = new Fish("Pesho");
            Fish fish2 = new Fish("Ada");
            Fish fish3 = new Fish("Adar");
            Fish fish4 = new Fish("Adara");

            aquarium.Add(fish1);
            aquarium.Add(fish2);

            List<Fish> myFishes = new List<Fish>();
            myFishes.Add(fish1);
            myFishes.Add(fish2);

            var actual = aquarium.Report();
            var reportFishes = string.Join(", ", myFishes.Select(f => f.Name));

            var expected = $"Fish available at {aquarium.Name}: {"Pesho, "}{"Ada"}"; // {myFishes}

            Assert.AreEqual(expected, actual);
        }
        
    }
}
