using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalculator.BinaryCalculators;
using NUnit.Framework;

namespace ICalculator.test
{
    [TestFixture]
    public class MultiplierTest
    {
        [Test]
        public void CalculateTest()
        {
            Multiplier multiplier = new Multiplier();
            Assert.AreEqual("49", multiplier.Calculate(7,7), "7*7 !=49");
        }
    }
}
