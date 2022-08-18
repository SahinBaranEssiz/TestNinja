using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{

    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZreo_ReturnNotFound()
        {

            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            //1. yol (kesin Not Found verdiği zaman için)
            Assert.That(result, Is.TypeOf<NotFound>());

            //2.yol (Not Found ya da türevleri için)
            //Assert.That(result, Is.InstanceOf<NotFound>());



        }

        [Test]
        public void GetCustomer_IdIdnotZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            //1. yol (kesin Ok verdiği zaman için)
            Assert.That(result, Is.TypeOf<Ok>());

            //2.yol (Ok ya da türevleri için)
            //Assert.That(result, Is.InstanceOf<Ok>());
        }



    }
}
