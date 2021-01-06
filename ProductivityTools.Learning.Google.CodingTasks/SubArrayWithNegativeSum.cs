using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    //https://www.geeksforgeeks.org/find-subarray-with-given-sum-in-array-of-integers/
    class SubArrayWithNegativeSum
    {
        private static void FindSubArray(int[] array, int expectedNumber)
        {
            Dictionary<int, int> hs = new Dictionary<int, int>();
            hs.Add(0, 0);
            int currentSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];

                if (hs.ContainsKey(currentSum - expectedNumber))
                {
                    Console.WriteLine("found");
                }
                hs.Add(currentSum, i);
            }
        }

        //hs{0,-41,-21,-22

        public static void Do()
        {
            int[] a = { 20, 20, -1, 42 };
            FindSubArray(a, 61);
        }
    }
}
