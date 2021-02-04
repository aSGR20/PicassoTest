using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void CalculateDemeritPoints_LessThanSpeedLimit_Returns0()
        {
            var speed = 20;
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(0));    
        }

        [Test]
        public void CalculateDemeritPoints_MoreThanSpeedLimit_LessThanMaxSpeed_ReturnsMoreThan0()
        {
            var speed = 80;
            var speedLimit = 65;
            var kmPerDemeritPoint = 5;
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo((speed - speedLimit) / kmPerDemeritPoint));
        }

        [Test]
        public void CalculateDemeritPoints_LessThan0_ThrowsArgumentOutOfRangeException()
        {
            var speed = -1;
            var calculator = new DemeritPointsCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_MoreThanMaxSpeed_ThrowsArgumentOutOfRangeException()
        {
            var speed = 350;
            var calculator = new DemeritPointsCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }
    }
}
