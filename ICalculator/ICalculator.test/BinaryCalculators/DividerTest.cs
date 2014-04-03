using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.test.BinaryCalculators
{
    [TestFixture]
    public class DividerTest
    {
        [Test]
        public void CalculateTest()
        {
            Divider divider = new Divider();
            Assert.AreEqual("6", divider.Calculate(36, 6), "36/6 !=6");
        }
    }
}

