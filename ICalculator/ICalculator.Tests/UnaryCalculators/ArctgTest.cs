using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
     [TestFixture]
    public class ArctgTest
    {
         [Test]
         public void CalculateTest()
         {
             Arctg arctg = new Arctg();
             Assert.AreEqual(1.5541, arctg.Calculate(60), 0.0001);
         }
    }
}
