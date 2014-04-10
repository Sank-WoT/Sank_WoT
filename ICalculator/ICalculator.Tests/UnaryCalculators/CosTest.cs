using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class CosTest
    {
        [Test]
        public void CalculateTest()
        {
            Cos cos = new Cos();
            Assert.AreEqual(0.5403, cos.Calculate(1), 0.0001);
        }
    }
}
