using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    public class LogTest
    {
        [Test]
        public void CalculateTest()
        {
            Log log = new Log();
            Assert.AreEqual(2, log.Calculate(4), 0.0001);
        }

        [Test]
        public void CalculateTestOne()
        {
            Log log = new Log();
            Assert.AreEqual(0, log.Calculate(1), 0.0001);
        }
    }
}
