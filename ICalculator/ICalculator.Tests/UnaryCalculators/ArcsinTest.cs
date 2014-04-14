using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class ArcsinTest
    {
        [Test]
        public void CalculateTest()
        {
            Arcsin arcsin = new Arcsin();
            Assert.AreEqual(1.5707963267949, arcsin.Calculate(1), 0.0001);
        }

        [Test]
        public void CalculateTestNegativ()
        {
            Arcsin arcsin = new Arcsin();
            Assert.AreEqual(-0.5236, arcsin.Calculate(-0.5), 0.0001);
        }
    }
}