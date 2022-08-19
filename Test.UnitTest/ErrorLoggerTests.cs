using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{

    
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger logger;
        [SetUp]
        public void SetUp()
        {
            // burası Arrange görevini üstleniyor 
            logger = new ErrorLogger();
        }


        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }


        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
        [Test]
        public void Log_ValidError_RaisedErrorLoggedEvent()
        {

            var id = Guid.Empty;
            //sender is source of event
            //args is event argument
            //=> {} our function
            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));


        }

    }
}
