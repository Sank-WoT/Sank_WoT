using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
    [TestFixture]
    public class ArccosTest
    {
        [Test]
        public void CalculateTest()
        {
            Arccos arccos = new Arccos();
            Assert.AreEqual("0", arccos.Calculate(Math.PI / 2), "arccos(PI/2) !=0");
        }
    }
}
