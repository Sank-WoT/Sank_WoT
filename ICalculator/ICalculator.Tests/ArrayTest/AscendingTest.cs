using ICalculator.SortiOperation;
using NUnit.Framework;

namespace ICalculator.Tests.ArrayTest
{
    [TestFixture]
    public class AscendingTest
    {
        [Test]
        public void CalculateTest()
        {
            int[] mas = new []{5,6,7,2,34,3,5,-43,6,-7};
            var ascending = new Ascending();
            int[] expected = new[] { -43, -7, 2, 3, 5, 5, 6, 6, 7, 34 };
            int[] result = ascending.Sort(mas);
            Assert.AreEqual(expected.Length,result.Length);
            for ( int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}