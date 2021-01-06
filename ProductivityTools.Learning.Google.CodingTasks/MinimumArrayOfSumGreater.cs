using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    public static class MinimumArrayOfSumGreater
    {
        static int smallestSubWithSumNaive(int[] arr, int x)
        {
            int sum;
            int minimumarray = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if(sum>x)
                    {
                        int localMinimumArray = j - i+1;
                        if(localMinimumArray<minimumarray)
                        {
                            minimumarray = localMinimumArray;
                        }
                    }
                }
            }
            return minimumarray;
        }

        static int smallestSubWithSum(int[] arr, int x)
        {
            // Initialize current  
            // sum and minimum length 
            int curr_sum = 0, min_len = arr.Length + 1;

            // Initialize starting and ending indexes 
            int start = 0, end = 0;
            while (end < arr.Length)
            {
                // Keep adding array elements  while current sum is smaller than x 
                while (curr_sum <= x && end < arr.Length)
                    curr_sum += arr[end++];

                // If current sum becomes greater than x. 
                while (curr_sum > x && start < arr.Length)
                {
                    // Update minimum  length if needed 
                    if (end - start < min_len)
                        min_len = end - start;

                    // remove starting elements 
                    curr_sum -= arr[start++];
                }
            }
            return min_len;
        }


        public static void Do()
        {
            int[] arr1 = {1, 4, 45,6, 10, 19};
            int x = 51;
            int n1 = arr1.Length;
            int res1 = smallestSubWithSum(arr1,x);
            int res1p = smallestSubWithSumNaive(arr1, x);
            if (res1 == n1 + 1)
                Console.WriteLine("Not Possible");
            else
                Console.WriteLine(res1);

            int[] arr2 = { 1, 10, 5, 2, 7 };
            int n2 = arr2.Length;
            x = 9;
            int res2 = smallestSubWithSum(arr2, x);
            if (res2 == n2 + 1)
                Console.WriteLine("Not Possible");
            else
                Console.WriteLine(res2);

            int[] arr3 = {1, 11, 100, 1, 0,
                      200, 3, 2, 1, 250};
            int n3 = arr3.Length;
            x = 280;
            int res3 = smallestSubWithSum(arr3, x);
            if (res3 == n3 + 1)
                Console.WriteLine("Not Possible");
            else
                Console.WriteLine(res3);
        }
    }
}
