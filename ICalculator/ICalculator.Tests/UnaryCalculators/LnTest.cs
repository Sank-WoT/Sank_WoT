using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class LnTest
    {
        [Test]
        public void CalculateTest()
        {
            Ln ln = new Ln();
            Assert.AreEqual(0, ln.Calculate(1), 0.0001);
        }
    }
}
