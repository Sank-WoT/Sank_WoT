using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class SqrtTest
    {
        [Test]
        public void CalculateTest()
        {
            Sqrt sqrt = new Sqrt();
            Assert.AreEqual(1, sqrt.Calculate(1), 0.0001);
        }
    }
}
