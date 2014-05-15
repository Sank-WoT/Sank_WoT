using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    public class Napierian_numberTest
    {
        [Test]
        public void CalculateTest()
        {
            NapierianNumber napierianNumber = new NapierianNumber();
            Assert.AreEqual(7.3890, napierianNumber.Calculate(2), 0.0001);
        }

        [Test]
        public void CalculateTestNegativ()
        {
            NapierianNumber napierianNumber = new NapierianNumber();
            Assert.AreEqual(0.135335, napierianNumber.Calculate(-2), 0.0001);
        }
    }
}
