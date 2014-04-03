using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.test.BinaryCalculators
{
    [TestFixture]
    public class MultiplierTest
    {
        [Test]
        public void CalculateTest()
        {
            Multiplier multiplier = new Multiplier();
            Assert.AreEqual("49", multiplier.Calculate(7,7), "7*7 !=49");
        }
    }
}
