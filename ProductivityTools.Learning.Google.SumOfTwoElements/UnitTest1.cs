using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductivityTools.Learning.Google.SumOfTwoElements
{
    class SumOfElements
    {
        public Tuple<int?,int?> Each(int[] array, int searchValue)
        {
            return new Tuple<int, int>();
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = 8;
            int[] a = new int[] { 1, 4, 6, 9 };
            int[] b = new int[] { 1, 2, 4, 4 };

            var c = new SumOfElements();
            var r=c.Each(a, result);
            Assert.AreEqual(null, r.Item1);
            Assert.AreEqual(null, r.Item2);
        }

    }
}
