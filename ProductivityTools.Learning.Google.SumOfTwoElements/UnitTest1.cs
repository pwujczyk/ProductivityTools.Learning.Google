using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductivityTools.Learning.Google.SumOfArrayElements;
using System;

namespace ProductivityTools.Learning.Google.SumOfTwoElements
{

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

            r = c.Each(b, result);
            Assert.AreEqual(4, r.Item1);
            Assert.AreEqual(4, r.Item2);

        }

    }
}
