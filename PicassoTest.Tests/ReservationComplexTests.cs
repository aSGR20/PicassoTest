using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class ReservationComplexTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new ReservationComplex();

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
            var reservation = new ReservationComplex { MadeBy = paco };

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
            var reservation = new ReservationComplex { MadeBy = paco };

            //Act
            var result = reservation.CanBeCancelledBy(pepe);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNull_ThrowsNullException()
        {
            //Arrange
            var paco = new User();
            var pepe = new User();
            var reservation = new Reservation { MadeBy = paco };

            //Act
            Assert.Throws<ArgumentNullException>(() => reservation.CanBeCancelledBy(null));
        }

        [Test]
        public void PayReservation_UserCanPaidReservation_ReturnsThrowsNotImplemented()
        {
            var userComplex = new UserComplex();
            var reservationComplex = new ReservationComplex();

            userComplex.Money = 100;
            reservationComplex.Price = 50;

            var result = reservationComplex.PayReservation(userComplex);

            Assert.Throws<NotImplementedException>(() => reservationComplex.PayReservation(userComplex));
        }

        [Test]
        public void PayReservation_UserIsNull_ReturnsThrowsNull()
        {
            var reservationComplex = new ReservationComplex();

            Assert.Throws<NullReferenceException>(() => reservationComplex.PayReservation(null));
        }
    }
}
