using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class ReservationTests   
    {
        [SetUp]
        public void Setup(){}

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = true
            });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            //Arrange
            var paco = new User();
            var reservation = new Reservation {  MadeBy = paco };

            //Act
            var result = reservation.CanBeCancelledBy(paco);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotMadeBy_ReturnsTrue()
        {
            //Arrange
            var paco = new User();
            var pepe = new User();
            var reservation = new Reservation { MadeBy = paco };

            //Act
            var result = reservation.CanBeCancelledBy(pepe);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNull_ThrowsNullRefernceException()
        {
            //Arrange
            var paco = new User();
            var pepe = new User();
            var reservation = new Reservation { MadeBy = paco };

            //Act
            Assert.Throws<NullReferenceException>(() => reservation.CanBeCancelledBy(null));
        }
    }
}
