using System;
using ICalculator.UnaryCalculators;
using NUnit.Framework;

namespace ICalculator.Tests.UnaryCalculators
{
    [TestFixture]
    public class SqrtTest
    {
        [Test]
        public void CalculateTest()
        {
            Sqrt sqrt = new Sqrt();
            Assert.AreEqual(1, sqrt.Calculate(1), 0.0001);

        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculateFailTest()
        {
            Sqrt sqrt = new Sqrt();
            sqrt.Calculate(-5);
        }
    }
}
