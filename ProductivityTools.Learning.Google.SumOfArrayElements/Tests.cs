using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ProductivityTools.Learning.Google.SumOfArrayElements
{
    public class Result
    {
        public int? R1;
        public int? R2;
        public bool Found;
        public int Count;

        public Result SetValues(int? r1, int? r2)
        {
            this.R1 = r1;
            this.R2 = r2;
            this.Found = true;
            return this;
        }
    }

    public class SumOfElements
    {
        public Result Each(int[] array, int searchValue)
        {
            Result r = new Result();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    r.Count++;
                    if (array[i] + array[j] == searchValue)
                    {
                        return r.SetValues(array[i], array[j]);
                    }
                }
            }
            return r;
        }

        private bool BinarySearch(ref int counter, int[] array, int min, int max, int searchedValue)
        {

            while (min <= max)
            {
                counter++;
                int mid = (min + max) / 2;
                if (array[mid] == searchedValue)
                {
                    return true;
                }

                if (array[mid] < searchedValue)
                {
                    min = mid + 1;
                }
                if (searchedValue < array[mid])
                {
                    max = mid - 1;
                }
            }
            return false;
        }

        public Result BinarySearchSum(int[] array, int searchValue)
        {
            Result r = new Result();
            for (int i = 0; i < array.Length; i++)
            {
                var item = array[i];
                r.Count++;
                var lookForValue = searchValue - item;
                if (BinarySearch(ref r.Count, array, i+1, array.Length - 1, lookForValue))
                {
                    return r.SetValues(item, lookForValue);
                }
            }
            return r;
        }
    }

    [TestClass]
    public class Tests
    {
        int[] array1 = new int[] { 1, 4, 6, 9 };
        int[] array2 = new int[] { 1, 2, 4, 4 };
        int result = 8;
        SumOfElements SumOfElements = new SumOfElements();

        [TestMethod]
        public void ForeachElementTest()
        {
            var r = SumOfElements.Each(array1, result);
            Assert.AreEqual(null, r.R1);
            Assert.AreEqual(null, r.R2);
            Console.WriteLine($"foreach element {r.Count}");

            r = SumOfElements.Each(array2, result);
            Assert.AreEqual(4, r.R1);
            Assert.AreEqual(4, r.R2);
            Console.WriteLine($"foreach element {r.Count}");
        }

        [TestMethod]
        public void BinarySearchTest()
        {
            var r = SumOfElements.BinarySearchSum(array1, result);
            Assert.AreEqual(null, r.R1);
            Assert.AreEqual(null, r.R2);
            Console.WriteLine($"binary element {r.Count}");

            r = SumOfElements.BinarySearchSum(array2, result);
            Assert.AreEqual(4, r.R1);
            Assert.AreEqual(4, r.R2);
            Console.WriteLine($"binary element {r.Count}");
        }

    }
}
