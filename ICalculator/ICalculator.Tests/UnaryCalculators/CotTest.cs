using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
     [TestFixture]
    public class CotTest
    {
         [Test]
         public void CalculateTest()
         {
             Cot cot = new Cot();
             Assert.AreEqual(0.6421, cot.Calculate(1), 0.0001);
         }
    }
}
