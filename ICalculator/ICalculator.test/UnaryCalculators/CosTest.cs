using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
    [TestFixture]
    public class CosTest
    {
        [Test]
        public void CalculateTest()
        {
            Cos cos = new Cos();
            Assert.AreEqual("0", cos.Calculate(1), "ln(1) !=0");
        }
    }
}
