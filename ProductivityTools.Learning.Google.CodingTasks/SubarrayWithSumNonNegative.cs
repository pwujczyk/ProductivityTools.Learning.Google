using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    class SubarrayWithSumNonNegative
    {
        //https://www.geeksforgeeks.org/find-subarray-with-given-sum/
        public static void Do()
        {
            int[] arr = new int[] { 1, 4, 20, 3, 10, 5 };
            int expectedvalue = 33;

            int leftIterator = 0;
            int rightIterator = 0;
            int sum = 0;
            while(leftIterator<arr.Length)
            {
                sum += arr[leftIterator++];
                if(sum==expectedvalue)
                {
                    Console.WriteLine("Found");
                }

                while(sum>expectedvalue)
                {
                    sum -= arr[rightIterator++];
                    if (sum == expectedvalue)
                    {
                        Console.WriteLine("Found");
                    }
                }
            }
            
        }
    }
}
