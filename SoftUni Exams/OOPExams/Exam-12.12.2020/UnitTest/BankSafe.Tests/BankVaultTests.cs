using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_firstThrowEx()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            Assert.Throws<ArgumentException>(() =>
            {
                bankVault.AddItem("Z", item);
            });
        }

        [Test]
        public void Add_secondThrowEx()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            bankVault.AddItem("A1", item);

            Assert.Throws<ArgumentException>(() => { bankVault.AddItem("A1", new Item("A", "2")); });
        }

        [Test]
        public void Add_cellExists()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            bankVault.AddItem("A1", item);

            Assert.Throws<InvalidOperationException>(() => { bankVault.AddItem("A2", new Item("Az", "1")); });
        }

        [Test]
        public void Add_SavedItem()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            var actual = bankVault.AddItem("A1", item);
            var expected = $"Item:{item.ItemId} saved successfully!";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_ItemCorrect()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            bankVault.AddItem("A1", item);

            var actual = bankVault.VaultCells["A1"];
            var expected = item;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_firstThrow()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");



            Assert.Throws<ArgumentException>(() =>
            {
                bankVault.RemoveItem("X", item);
            });
        }

        [Test]
        public void Remove_secondThrow()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            Assert.Throws<ArgumentException>(() =>
            {
                bankVault.RemoveItem("A1", item);
            });
        }

        [Test]
        public void Remove_Work()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            bankVault.AddItem("A1", item);

            var actual = bankVault.RemoveItem("A1", item);
            var expected = $"Remove item:{item.ItemId} successfully!";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_WorkCellNull()
        {
            var bankVault = new BankVault();
            var item = new Item("Az", "1");

            bankVault.AddItem("A1", item);
            bankVault.RemoveItem("A1", item);

            Item actual = bankVault.VaultCells["A1"];
            Item expected = null;


            Assert.AreEqual(expected, actual);
        }
    }
}