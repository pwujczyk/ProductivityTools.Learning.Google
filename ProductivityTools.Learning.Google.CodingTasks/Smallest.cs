using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    public static class Smallest
    {

        static int findSmallest(int[] arr)
        {
            // Initialize result 
            int result = 1;

            // Traverse the array and  
            // increment 'res' if arr[i] is 
            // smaller than or equal to 'res'. 
            for (int i = 0; i < arr.Length && arr[i] <= result; i++)
            {
                Console.WriteLine(result);
                result = result + arr[i];
            }

            return result;
        }

        public static void Do()
        {
            int[] arr1 = { 1, 2, 3, 5, 7 };
            Console.WriteLine($"result: {findSmallest(arr1)}");

            int[] arr2 = { 1, 2, 6, 10, 11, 15 };
            int n2 = arr2.Length;
            Console.WriteLine(findSmallest(arr2));

            int[] arr3 = { 1, 1, 1, 1 };
            Console.WriteLine(findSmallest(arr3));

            int[] arr4 = { 1, 1, 3, 4 };
            Console.WriteLine(findSmallest(arr4));

        }
    }
}
