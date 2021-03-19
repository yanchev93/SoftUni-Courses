using System;

using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Database extendedDatabase;
        private Person[] persons;

        [SetUp]
        public void Setup()
        {
            this.database = new Database(initialData);

            Person person1 = new Person(123, "Pesho");
            Person person2 = new Person(1234, "Gosho");
            Person person3 = new Person(12345, "Mitko");
            Person person4 = new Person(123456, "Stoqn");

            this.extendedDatabase = new Database();

            this.extendedDatabase.Add(person1);
            this.extendedDatabase.Add(person2);
            this.extendedDatabase.Add(person3);
            this.extendedDatabase.Add(person4);
        }

        [Test]
        public void AddShouldThrowInvalidOperationExceptionIfTheSameIDIsUsed()
        {
            // Arrange
            Person person = new Person(123, "Ivan");

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            { this.extendedDatabase.Add(person); }); // Act
        }

        [Test]
        public void AddShouldThrowInvalidOperationExceptionIfTheSameUserNameIsUsed()
        {
            // Arrange
            Person person = new Person(234, "Pesho");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            { this.extendedDatabase.Add(person); }); // Act
        }

        [Test]
        public void RemoveShouldThrowInvalidOperationExceptionIfThereIsNoPersonsInTheDatabase()
        {
            // Arrange
            this.extendedDatabase.Remove();
            this.extendedDatabase.Remove();
            this.extendedDatabase.Remove();
            this.extendedDatabase.Remove();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.extendedDatabase.Remove(); // Act
            });
        }

        [Test]
        public void CountShouldIncreaseWhenNewUserIsAdded()
        {
            // Arrange
            Person person = new Person(111, "Stoicho");

            // Act
            int expectedCount = 5;

            this.extendedDatabase.Add(person);

            int actualCount = this.extendedDatabase.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountShouldDecreseWhenUserIsRemovedById()
        {
            // Arrange
            int expectedCount = 3;

            // Act
            this.extendedDatabase.Remove();
            int actualCount = this.extendedDatabase.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void FindByUsernameShouldThrowInvalidOperationExceptionIfNoUserExistWithTheGivenUsername()
        {
            // Arrange
            string findByName = "Dimcho";

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.extendedDatabase.FindByUsername(findByName); // Act
            });
        }

        [Test]
        public void FindByUserNameShouldThrowArgumentNullExceptionIfEmptyStringIsPassed()
        {
            // Arrange
            string findByName = string.Empty;

            // Arrange
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.extendedDatabase.FindByUsername(findByName);
            });
        }

        [Test]
        public void FindByUserNameShouldThrowArgumentNullExceptionIfNullIsPassed()
        {
            // Arrange
            string findByName = null;

            // Arrange
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.extendedDatabase.FindByUsername(findByName);
            });
        }

        [Test]
        public void FindByIDShouldThrowInvalidOperationExceptionIfNoIDExistWithTheGivenID()
        {
            // Arrange
            int findById = 007;

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.extendedDatabase.FindById(findById); // Act
            });
        }

        [Test]
        public void FindByIDShouldThrowArgumenOutOfRangeExceptionIfNegativeIdIsGiven()
        {
            // Arrange
            int findById = -1;

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.extendedDatabase.FindById(findById);
            });
        }

        [Test]
        public void ConsturctorAddRangeShouldAddPersons()
        {
            // Arrange

            Database extendedData = new Database();

            // Act

            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(i, $"Jhonny{i}");

                extendedData.Add(person);
            }

            int expectedCount = 16;
            int actualCount = extendedData.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowArgumentExceptionIfMoreThan16PersonsAreAdded()
        {
            // Arrange
            Person person1 = new Person(0, "A");
            Person person2 = new Person(1, "B");
            Person person3 = new Person(2, "C");
            Person person4 = new Person(3, "D");
            Person person5 = new Person(4, "E");
            Person person6 = new Person(5, "F");
            Person person7 = new Person(6, "G");
            Person person8 = new Person(7, "H");
            Person person9 = new Person(8, "J");
            Person person10 = new Person(9, "K");
            Person person11 = new Person(10, "L");
            Person person12 = new Person(11, "M");
            Person person13 = new Person(12, "N");
            Person person14 = new Person(13, "O");
            Person person15 = new Person(14, "P");
            Person person16 = new Person(15, "Q");
            Person person17 = new Person(16, "R");

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Database extendedData = new Database(person1, person2, person3, person4, person5, person6, person7, person8, person9, person10, person11, person12, person13, person14, person15, person16, person17); // Act
            });
        }

        [Test]
        public void AddShouldThrowInvalidOperationExceptionIfCountIs16AndWeTryToAddOneMorePerson()
        {
            // Arrange
            Database extendedData = new Database();

            // Act
            for (int i = 1; i <= 16; i++)
            {
                Person person = new Person(i, $"A{i}");

                extendedData.Add(person);
            }

            Person person0 = new Person(16, "Ivan");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedData.Add(person0);
            });
        }

        [Test]
        public void Count16()
        {
            Database data = new Database();

            for (int i = 1; i <= 16; i++)
            {
                Person person = new Person(i, $"A{i}");

                data.Add(person);
            }

            int expectedCount = 16;
            int actualCount = data.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldInitializeCollection()
        {
            Person person1 = new Person(2, "Stoian");
            Person person2 = new Person(3, "Ivancho");

            var expected = new Person[] { person1, person2 };

            var db = new Database(expected);

            var actual = db.Fetch();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveShouldRemove()
        {
            var pesho = new Person(1, "P");
            var gosho = new Person(2, "G");

            var persons = new Person[] { pesho, gosho };
            var db = new Database(persons);
            db.Remove();

            var actual = db.Fetch();
            var expected = new Person[] { pesho };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}