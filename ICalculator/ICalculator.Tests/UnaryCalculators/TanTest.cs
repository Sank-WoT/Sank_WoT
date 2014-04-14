using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
      [TestFixture]
    public class TanTest
    {
          [Test]
          public void CalculateTest()
          {
              Tan tan = new Tan();
              Assert.AreEqual(1.5574, tan.Calculate(1), 0.0001);
          }

          [Test]
          public void CalculateTestNegativ()
          {
              Tan tan = new Tan();
              Assert.AreEqual(-1.5574, tan.Calculate(-1), 0.0001);
          }
    }
}
