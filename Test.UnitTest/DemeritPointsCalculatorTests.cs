using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TestNinja.Fundamentals;
using System.Threading.Tasks;


namespace Test.UnitTest
{
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void DemeritPointsCalculator_WhenOverTheSppedLimit_ReturnDemiterPoints()
        {
            var demeritPoints = new DemeritPointsCalculator();
            var result = demeritPoints.CalculateDemeritPoints(85);

            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void DemeritPointsCalculator_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int result)
        {
            var demeritPoints = new DemeritPointsCalculator();
            //Throws içersinde ArgumentOutOfRangeException olmadığı için özellikle tipini belirtiyoruz
            Assert.That(() => demeritPoints.CalculateDemeritPoints(result),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


    }
}
