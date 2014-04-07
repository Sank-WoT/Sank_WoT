using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
    [TestFixture]
    public class SqrtTest
    {
        [Test]
        public void CalculateTest()
        {
            Sqrt sqrt = new Sqrt();
            Assert.AreEqual("1", sqrt.Calculate(1), "sqrt(1) !=1");
        }
    }
}
