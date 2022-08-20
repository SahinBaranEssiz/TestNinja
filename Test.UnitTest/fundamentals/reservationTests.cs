using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBecancelledBy_UserIsAdmin_ReturnTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User{ IsAdmin = true });

            // Assert
            //NUnit kurulumu ile aşağıdaki 3'ü de kullanılabilir 
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);

        }
        [Test]
        public void CanBecancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBecancelledBy_AnotherUsercancellingReservation_ReturnFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }


    }
}
