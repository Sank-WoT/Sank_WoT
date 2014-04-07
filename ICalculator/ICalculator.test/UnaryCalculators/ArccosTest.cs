﻿using System;
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
            Assert.AreEqual("1,0471975511966", arccos.Calculate(0.5), "arccos(0.5) !=1,0471975511966");
        }
    }
}
