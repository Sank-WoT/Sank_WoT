using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class SinTest
    {
        [Test]
        public void CalculateTest()
        {
            Sin sin = new Sin();
            Assert.AreEqual(0.8415, sin.Calculate(1), 0.0001);
        }
    }
}
