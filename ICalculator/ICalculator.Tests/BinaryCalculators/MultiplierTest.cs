using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.BinaryCalculators
{
    [TestFixture]
    public class MultiplierTest
    {
        [Test]
        public void CalculateTest()
        {
            Multiplier multiplier = new Multiplier();
            Assert.AreEqual(49, multiplier.Calculate(7,7),0.0001);
        }
        [Test]
        public void CalculateNegativeTest()
        {
            Multiplier multiplier = new Multiplier();
            Assert.AreEqual(-49, multiplier.Calculate(7, -7), 0.0001);
        }
    }
}
