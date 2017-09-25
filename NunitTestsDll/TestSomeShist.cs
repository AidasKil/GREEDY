using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitTestsDll
{
    [TestFixture]
    public class TestSomeShist
    {

        [Test]
        public void Test()
        {
            Assert.That(0, Is.EqualTo(0));
        }
    }
}
