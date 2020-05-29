using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.SumOfArrayElements
{
    public class SumOfElements
    {
        public Tuple<int?, int?> Each(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    Console.WriteLine(i);
                    if (array[i]+array[j]== searchValue)
                    {
                        return new Tuple<int?, int?>(array[i], array[j]);
                    }
                }
            }
            return new Tuple<int?, int?>(null, null);
        }
    }

    [TestClass]
    public class Tests
    {
        private void MakeTest(int[]array, int? a, int? b)
        {
            int result = 8;
            var c = new SumOfElements();
            var r = c.Each(array, result);

            Assert.AreEqual(a, r.Item1);
            Assert.AreEqual(b, r.Item2);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] array1 = new int[] { 1, 4, 6, 9 };
            MakeTest(array1, null, null);

            int[] array2 = new int[] { 1, 2, 4, 4 };
            MakeTest(array2,4, 4);
           

        }

    }
}
