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
    public class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalledDelteTheEmployeeFromDb()
        {
            var storage = new Mock<IEmployeeStorage>();
            var contoller = new EmployeeController(storage.Object);
            contoller.DeleteEmployee(1);
            storage.Verify(s => s.DelteEmployee(1));
        }

    }
}
