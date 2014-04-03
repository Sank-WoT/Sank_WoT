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
    public class InvolutionTest
    {
        [Test]
        public void CalculateTest()
        {
            Involution involution = new Involution();
            Assert.AreEqual("8", involution.Calculate(2, 3), "2^3 !=8");
        }
    }
}
