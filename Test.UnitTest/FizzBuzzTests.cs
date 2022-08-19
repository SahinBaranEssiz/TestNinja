using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        

        [Test]
        public void FizzBuzz_WhenCalled_ReturnFizzBuzz()
        {            
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));        

        }
        [Test]
        public void FizzBuzz_WhenCalled_ReturnBuzz()
        {            
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));

        }
        [Test]
        public void FizzBuzz_WhenCalled_ReturnFizz()
        {            
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));

        }
        [Test]
        public void FizzBuzz_WhenCalled_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));

        }

        //[Test]
        //[TestCase("FizzBuzz",15 )]
        //[TestCase(5, "Buzz")]
        //[TestCase(3, "Fizz")]
        //public void FizzBuzz_WhenCalled_ReturnFizzBuzz(int number,   expectedResult)
        //{
        //    //var fizzbuzz = new FizzBuzz();
        //    var result = FizzBuzz.GetOutput(number);

        //    Assert.That(result, Does.Contain(expectedResult));
        //}

    }
}
