using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
    [TestFixture]
    public class LnTest
    {
        [Test]
        public void CalculateTest()
        {
            Ln ln = new Ln();
            Assert.AreEqual("0", ln.Calculate(1), "ln(1) !=0");
        }
    }
}
