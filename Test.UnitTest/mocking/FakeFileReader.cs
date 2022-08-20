using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UnitTest.mocking
{
    [TestFixture]
    public class FakeFileReader
    {
        [Test]
        public string Read(string path)
        {

            FakeFileReader reader = new FakeFileReader();
            reader.Read(path);
            return "";

        }
    }
}
