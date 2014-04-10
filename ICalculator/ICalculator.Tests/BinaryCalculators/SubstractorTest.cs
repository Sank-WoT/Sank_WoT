using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.BinaryCalculators
{
    [TestFixture]
    public class SubstractorTest
    {
        [Test]
        public void CalculateTest()
        {
            Substractor substractor = new Substractor();
            Assert.AreEqual(20, substractor.Calculate(50, 30),0.0001);
        }
        [Test]
        public void CalculateNegativeTest()
        {
            Substractor substractor = new Substractor();
            Assert.AreEqual(80, substractor.Calculate(50, -30), 0.0001);
        }
    }
}
