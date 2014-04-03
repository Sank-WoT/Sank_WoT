using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.test.BinaryCalculators
{
    [TestFixture]
    public class SubstractorTest
    {
        [Test]
        public void CalculateTest()
        {
            Substractor substractor = new Substractor();
            Assert.AreEqual("20", substractor.Calculate(50, 30), "50-30 !=20");
        }
    }
}
