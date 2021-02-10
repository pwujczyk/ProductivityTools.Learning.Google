using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    //https://www.geeksforgeeks.org/minimum-length-subarray-sum-greater-given-value/?ref=lbp
    public static class MinimumArrayOfSumGreater2
    {
        static int smallestSubWithSumNaive(int[] arr, int x)
        {
  
        }

        static int smallestSubWithSum(int[] arr, int x)
        {
            var hashSet = new HashSet<int>();

            int pointSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                pointSum += arr[i];

                if (hashSet.Contains(
                    
                        

                    hashSet.Add(x - pointSum);

                
            }
        }

        static int smallestSubWithSum2(int[] arr, int x)
        {
            int currentSum = 0;
            int rightIterator = 0;
            int leftIterator = 0;
            int minimumLength = int.MaxValue;
            while (rightIterator < arr.Length)
            {
                while (currentSum < x && rightIterator < arr.Length)
                {
                    currentSum += arr[rightIterator++];
                }

                int currentLength = rightIterator - leftIterator;
                if (currentLength < minimumLength)
                {
                    minimumLength = currentLength;
                }

                while(currentSum>=x)
                {
                    currentSum -= arr[leftIterator++];
                }
            }
            return minimumLength;
        }


        public static void Do()
        {
            int[] arr1 = { 1, 4, 45, 6, 10, 19 };
            int x = 51;
            int n1 = arr1.Length;
            int res1 = smallestSubWithSum(arr1, x);
            int res1p = smallestSubWithSumNaive(arr1, x);
            int res1p2 = smallestSubWithSum2(arr1, x);
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
