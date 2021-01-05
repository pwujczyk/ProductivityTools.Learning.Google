using System;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    class Program
    {
        static int findSmallest(int[] arr, int n)
        {
            // Initialize result 
            int res = 1;

            // Traverse the array and  
            // increment 'res' if arr[i] is 
            // smaller than or equal to 'res'. 
            for (int i = 0; i < n &&
                 arr[i] <= res; i++)
                res = res + arr[i];

            return res;
        }

        // Driver code 
        public static void Main()
        {
            int[] arr1 = { 1, 2, 3, 5, 7 }
            int n1 = arr1.Length;
            Console.WriteLine(findSmallest(arr1, n1));

            int[] arr2 = { 1, 2, 6, 10, 11, 15 };
            int n2 = arr2.Length;
            Console.WriteLine(findSmallest(arr2, n2));

            int[] arr3 = { 1, 1, 1, 1 };
            int n3 = arr3.Length;
            Console.WriteLine(findSmallest(arr3, n3));

            int[] arr4 = { 1, 1, 3, 4 };
            int n4 = arr4.Length;
            Console.WriteLine(findSmallest(arr4, n4));

        }
    }
}
