using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("BMW", "125", 1.25, 100);
        }

        [Test]
        public void ConstructorCarInitializing()
        {
            // Arrange
            string make = "Audi";
            string model = "A3";
            double fuelConsumption = 1.5;
            double fuelCapacity = 100;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            // Act
            car.Refuel(50);

            double expectedFuelAmount = 50;
            double actualFuelAmount = car.FuelAmount;

            // Arrange
            Assert.That(actualFuelAmount, Is.EqualTo(expectedFuelAmount));
        }

        [Test]
        public void MakeShouldThrowArgumentExceptionIfNullIsSend()
        {
            // Arrange
            Car car;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(null, "125", 1.25, 100);
            });
        }

        [Test]
        public void MakeShouldThrowArgumentExceptionIfEmptyIsSend()
        {
            // Arrange
            Car car;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("", "125", 1.25, 100);
            });
        }

        [Test]
        public void ModelShouldTHrowArgumenExceptionIfNullIsSend()
        {
            // Arrange
            Car car;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", null, 1.25, 100);
            });
        }

        [Test]
        public void ModelShouldThrowArgumentExceptionIfEmptyIsSend()
        {
            // Arrange
            Car car;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", "", 1.25, 100);
            });
        }

        [Test]
        public void MakeShouldReturnTheGivenModelWhenRead()
        {
            string expectedMake = "BMW";
            string actualMake = this.car.Make;

            Assert.AreEqual(expectedMake, actualMake);
        }

        [Test]
        public void ModelShouldReturnTheGivenModelWhenRead()
        {
            string expectedModel = "125";
            string actualModel = this.car.Model;

            Assert.AreEqual(expectedModel, actualModel);
        }

        [Test]
        public void FuelConsumptionShouldReturnTheSetThruConstructorValue()
        {
            double expectedFuelConsumption = 1.25;
            double actualFuelConsumption = this.car.FuelConsumption;

            Assert.AreEqual(expectedFuelConsumption, actualFuelConsumption);
        }

        [Test]
        public void FuelCapacityShouldReturnTheSetThruConstuctorValue()
        {
            double expectedFuelCapacity = 100;
            double actualFuelCapacity = this.car.FuelCapacity;

            Assert.AreEqual(expectedFuelCapacity, actualFuelCapacity);
        }

        [Test]
        public void FuelConsumptionShouldThrowArgumentExceptionIfZeroIsSend()
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", "125", 0.0000, 100);
            });
        }

        [Test]
        public void FuelConsumptionShouldTHrowArgumentExceptionIfNegativeNumberIsSend()
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", "125", -55, 100);
            });
        }

        [Test]
        public void FuelAmountShouldThrowArgumentExceptionIfNegativeNumberIsSend()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.car.Refuel(-22);
            });
        }

        [Test]
        public void FuelCapacityShouldThrowArgumentExceptionIfZeroIsSend()
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", "125", 1.25, 0);
            });
        }

        [Test]
        public void FuelCapacityShouldThrowArgumentExceptionIfNegativeNumberIsSend()
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("BMW", "125", 1.25, -50);
            });
        }

        [Test]
        public void RefuelShouldSetTheFuelAmountToTheFuelCapacityIfTheFuelAmountIsBiggerThanTheFuelCapacity()
        {
            Car car = new Car("BMW", "125", 1.25, 100);

            car.Refuel(125);

            double expectedFuelAmount = 100;
            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void FuelAmountShouldThrowArgumentExceptionIfZeroIsSend()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.car.Refuel(0);
            });
        }

        [Test]
        public void DriveShouldThrowInvalidOperationExceptionIfTheFuelAmountIsNotEnough()
        {
            this.car.Refuel(20);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.car.Drive(2000);
            });
        }

        [Test]
        public void DriveShouldDriveTheGivenDistanceIfTheFuelAmountIsEnough()
        {
            // Arrange
            this.car.Refuel(2.5);

            // Act
            this.car.Drive(200);

            double expectedFuelAmount = 0.0;
            double actualFuelAmount = this.car.FuelAmount;

            // Assert
            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void FuelAmountShouldBeZeroIfNoRefuelIsSet()
        {
            double expectedFuelAmount = 0;
            double actualFuelAmount = this.car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }
    }
}