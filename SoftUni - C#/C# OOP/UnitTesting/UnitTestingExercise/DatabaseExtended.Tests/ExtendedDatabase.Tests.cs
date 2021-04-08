using System;

using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDb;

        [SetUp]
        public void Setup()
        {
            Person person1 = new Person(123, "Pesho");
            Person person2 = new Person(1234, "Gosho");
            Person person3 = new Person(12345, "Mitko");
            Person person4 = new Person(123456, "Stoqn");

            this.extendedDb = new ExtendedDatabase();

            this.extendedDb.Add(person1);
            this.extendedDb.Add(person2);
            this.extendedDb.Add(person3);
            this.extendedDb.Add(person4);
        }

        [Test]
        public void Add_ThrowException_WhenMoreThan16PeopleAreAdded()
        {

            Person[] people = new Person[17];

            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person(i, $"Username{i}");

                people[i] = person;
            }


            Assert.Throws<ArgumentException>(() =>
            {
                ExtendedDatabase db =
                new ExtendedDatabase(people);
            });
        }

        [Test]
        public void Count_ShouldReturnCorrectValueWhenUsed()
        {
            int expectedCount = 4;
            int actualCount = this.extendedDb.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Add_ShouldThrowExceptionIfMoreThan16PeopleAreTryedToBeAdded()
        {
            ExtendedDatabase exDB = new ExtendedDatabase();

            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(i, $"Username{i}");

                exDB.Add(person);
            }

            Person addPerson = new Person(321, "Abcd");

            Assert.Throws<InvalidOperationException>(() =>
            exDB.Add(addPerson));
        }

        [Test]
        public void Add_ShouldThrowExceptionIfTheSameUsernameIsTriedToBeAdded()
        {
            Person person = new Person(222, "Gosho");

            Assert.Throws<InvalidOperationException>(() => this.extendedDb.Add(person));
        }

        [Test]
        public void Add_ShouldThrowExceptionIfTheSameIDIsTriedToBeAdded()
        {
            Person person = new Person(123, "Abc");

            Assert.Throws<InvalidOperationException>(() => this.extendedDb.Add(person));
        }

        [Test]
        public void Remove_ShouldDecreaseTheCount()
        {
            this.extendedDb.Remove();
            this.extendedDb.Remove();
            this.extendedDb.Remove();

            int expectedCount = 1;
            int actualCount = this.extendedDb.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_ShouldThrowException()
        {
            this.extendedDb.Remove();
            this.extendedDb.Remove();
            this.extendedDb.Remove();
            this.extendedDb.Remove();

            Assert.Throws<InvalidOperationException>(() => this.extendedDb.Remove());
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ShouldThrowArgumentNullException(string userName)
        {
            Assert.Throws<ArgumentNullException>(() => this.extendedDb.FindByUsername(userName));
        }

        [Test]
        [TestCase("Ivan")]
        public void FindByUsername_ShouldThrowInvalidOperationException(string userName)
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDb.FindByUsername(userName));
        }

        [Test]
        [TestCase("Gosho")]
        public void FindByUsername_ShouldReturnThePerson(string userName)
        {
            Person expectedUsername = new Person(1234, "Gosho");
            Person actualUsername = this.extendedDb.FindByUsername(userName);

            Assert.That(actualUsername.Id, Is.EqualTo(expectedUsername.Id));
            Assert.That(actualUsername.UserName, Is.EqualTo(expectedUsername.UserName));
        }

        [Test]
        [TestCase(-20)]
        public void FindById_ShouldThrowArgumentOutOfRangeException(int id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => this.extendedDb.FindById(id));
        }

        [Test]
        [TestCase(0102)]
        public void FindById_ShouldThrowInvalidOperationException(int id)
        {
            Assert.Throws<InvalidOperationException>(
                () => this.extendedDb.FindById(id));
        }

        [Test]
        [TestCase(1234)]
        public void FindById_ShouldReturnTheSamePerson(int id)
        {
            Person expectedPerson = new Person(1234, "Gosho");
            Person actualPerson = this.extendedDb.FindById(id);

            Assert.That(actualPerson.Id, Is.EqualTo(expectedPerson.Id));
            Assert.That(actualPerson.UserName, Is.EqualTo(expectedPerson.UserName));
        }
    }
}








