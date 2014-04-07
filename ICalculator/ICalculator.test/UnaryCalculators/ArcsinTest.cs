using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
    [TestFixture]
    public class ArcsinTest
    {
        [Test]
        public void CalculateTest()
        {
            Arcsin arcsin = new Arcsin();
            Assert.AreEqual("1,5707963267949", arcsin.Calculate(1), "arcsin(0) !=1,5707963267949");
        }
    }
}