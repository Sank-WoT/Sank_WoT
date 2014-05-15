using ICalculator.SortiOperation;
using NUnit.Framework;

namespace ICalculator.Tests.ArrayTest
{
        [TestFixture]
   public  class DescendingTest
    {
            [Test]
            public void CalculateTest()
            {
                int[] mas = new[] { 5, 6, 7, 2, 34, 3, 5, -43, 6, -7 };
                Descending descending = new Descending();
                int[] expected = new[] { 34, 7, 6, 6, 5, 5, 3, 2, -7, -43 };
                int[] result = descending.Sort(mas);
                Assert.AreEqual(expected.Length, result.Length);
                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }

    }
}
