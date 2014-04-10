using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.BinaryCalculators
{
    [TestFixture]
    public class InvolutionTest
    {
        [Test]
        public void CalculateTest()
        {
            Involution involution = new Involution();
            Assert.AreEqual(8, involution.Calculate(2, 3),0.0001);
        }
        [Test]
        public void CalculateNegativeTest()
        {
            Involution involution = new Involution();
            Assert.AreEqual(0.125, involution.Calculate(2, -3), 0.0001);
        }
    }
}
