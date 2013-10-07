using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass.Tests
{
    [TestFixture]
    public class SecondClassTests
    {
        [Test]
        public void BatmanTest()
        {
            NUnitSample.SecondClass c = new NUnitSample.SecondClass();
            var result = c.TheDarkKnight();
            Assert.AreEqual("Rises",result);
        }
        [Test]
        public void BaneTest()
        {
            NUnitSample.SecondClass c = new NUnitSample.SecondClass();
            var result = c.Bane();
            Assert.AreNotEqual("Removes mask",result);
        }
    }
}
