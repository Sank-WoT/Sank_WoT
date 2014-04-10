using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.BinaryCalculators
{
    [TestFixture]
    public class AdditorTest
    {
        [Test]
        public void  CalculateTest()
        {
             Additor additor= new Additor();
             Assert.AreEqual(2,additor.Calculate(1,1),0.0001);
        }
        [Test]
        public void CalculateNegativeTest()
        {
            Additor additor = new Additor();
            Assert.AreEqual(0, additor.Calculate(1, -1), 0.0001);
        }
    }
}
