using System;

using NUnit.Framework;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        private readonly int[] initialData = new int[] { 1, 2, 3 };

        [SetUp]
        public void Setup()
        {
            this.database = new Database(initialData);
        }

        [Test]
        public void DatabaseCapacityIsExactly16()
        {
            // Arrange
            Database database = new Database(new int[] { 1, 2, 3 });
            for (int i = 3; i < 16; i++)
            {
                database.Add(i);
            }

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(17);
            });
        }

        [Test]
        public void AddElementToTheArrayIfThereIsAFreeSpace()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3 };
            this.database = new Database(data);

            // Act
            this.database.Add(4);

            int expectedCount = 4;
            int actualCount = this.database.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);

        }

        [Test]
        public void CountArrayTest()
        {
            // Arrange
            Database database = new Database(new int[] { 1, 2, 3, 4 });

            // Act
            int expectedCount = 4;
            int actualCount = database.Count;
            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ThrowExceptionIfArrayIsEmpty()
        {
            // Act
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Remove();
            });
        }

        [Test]
        public void RemoveAtLastIndexShouldReturnThePreviousElement()
        {
            // Arrange
            Database database = new Database(new int[] { 1, 2, 3, 4 });

            // Act
            int expectedOutput = 3;
            int actualOutput = 3;
            database.Remove();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchExpectedData(int[] expectedData)
        {
            // Arrange
            this.database = new Database(expectedData);

            // Act
            int[] actualData = this.database.Fetch();

            // Assert
            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}