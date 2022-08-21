using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;
using TestNinja.Mocking;
using Moq;

namespace Test.UnitTest.mocking
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100};

            var result = product.GetPrice(new Customer { IsGold = true });

            Assert.AreEqual(70, result);
        }
        //mocking dışardan veri alınma durumunda kullanıyoruz
        // ama burda gördüğümüz gibi her zaman kullanmak mantıklı değil gereksiz kod şişirmesine sebeb olabiliyor
        
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var product = new Product {ListPrice = 100};

            var result = product.GetPrice(customer.Object);

            Assert.AreEqual(70, result);
        }


    }
}
