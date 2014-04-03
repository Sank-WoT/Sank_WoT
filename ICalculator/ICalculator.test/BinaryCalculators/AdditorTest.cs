using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.test.BinaryCalculators
{
    [TestFixture]
    public class AdditorTest
    {
        [Test]
        public void  CalculateTest()
        {
             Additor additor= new Additor();
             Assert.AreEqual("2",additor.Calculate(1,1),"1+1 !=2");
        }
    }
}
