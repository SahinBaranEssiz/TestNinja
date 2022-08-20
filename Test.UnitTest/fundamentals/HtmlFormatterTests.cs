using NUnit.Framework;
using TestNinja.Fundamentals;


namespace Test.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]

        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            

            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //özel
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // daha genel 
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>"));

        }



    }
}
