using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class ArccosTest
    {
        [Test]
        public void CalculateTest()
        {
            Arccos arccos = new Arccos();
            Assert.AreEqual(1.0471975511966, arccos.Calculate(0.5),0.0001);
        }

        [Test]
        public void CalculateTestNegativ()
        {
            Arccos arccos = new Arccos();
            Assert.AreEqual(2.0944, arccos.Calculate(-0.5), 0.0001);
        }
    }
}
