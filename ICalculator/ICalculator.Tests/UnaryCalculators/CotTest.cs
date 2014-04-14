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
              Assert.AreEqual(3.1246, cot.Calculate(60), 0.0001);
          }

          [Test]
          public void CalculateTestNegativ()
          {
              Cot cot = new Cot();
              Assert.AreEqual(-3.1246, cot.Calculate(-60), 0.0001);
          }
    }
}
