using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    public class Napierian_numberTest
    {
        [Test]
        public void CalculateTest()
        {
            Napierian_number napierian_number = new Napierian_number();
            Assert.AreEqual(7.3890, napierian_number.Calculate(2), 0.0001);
        }

        [Test]
        public void CalculateTestNegativ()
        {
            Napierian_number napierian_number = new Napierian_number();
            Assert.AreEqual(0.135335, napierian_number.Calculate(-2), 0.0001);
        }
    }
}
