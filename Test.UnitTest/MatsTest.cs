using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{
    [TestFixture]
    public class MatsTest
    {

        private TestNinja.Fundamentals.Math _math;
        [SetUp]
        public void SetUp()
        {
            // burası Arrange görevini üstleniyor 
            _math = new TestNinja.Fundamentals.Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange

            // Act
            int result = _math.Add(5,5);

            // Assert
            Assert.AreEqual(result,10);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Arrange

            // Act
            var result = _math.Max(a,b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_GetOddNumbers_LimitIsGreaterThanZero_ReruntOddNumberUpToLimit()
        {
            //liste kullanılcağı zaman "ReferenceEquals" kullanılması gerekmektedir çünkü "AreEqual" hash numaralarınıda karşılaştırıyor 
            

                //1.yol
            //IEnumerable<int> result = _math.GetOddNumbers(6);
            //int[] oddNumber = { 1, 3, 5 };
            //CollectionAssert.AreEquivalent(result, oddNumber);

                //2.yol
            var result = _math.GetOddNumbers(6);
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            //üstteki 3 satır aşağıda ki ile aynı işlemi yapmakta
            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));

                //sıralı sonuç için
            //Assert.That(result, Is.Ordered);

                //içindekiler tekrarlıyor mu diye kontrol ediyor
            //Assert.That(result, Is.Unique);
        }


    }
}
