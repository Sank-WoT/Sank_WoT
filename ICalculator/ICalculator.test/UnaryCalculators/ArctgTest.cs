using System;
using NUnit.Framework;

namespace ICalculator.UnaryCalculators
{
     [TestFixture]
    public class ArctgTest
    {
         [Test]
         public void CalculateTest()
         {
             Arctg arctg = new Arctg();
             Assert.AreEqual("98,93906527", arctg.Calculate(60), "arctg(60) !=1,0471975511966");
         }
    }
}
