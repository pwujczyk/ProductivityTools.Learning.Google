using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    //https://www.geeksforgeeks.org/size-subarray-maximum-sum/?ref=lbp
    class SizeOfSubarrayWithMaximumSum
    {
        public static void Do()
        {
            int[] array = new int[] { 1, -2, 1, 1, -2, 1 };

            int startPoint = 0;
            int sum = 0;
            int maxArraySize = 0;
            int currentMaxArraySize = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if(sum>0)
                {
                    currentMaxArraySize++;
                    if (currentMaxArraySize > maxArraySize) { maxArraySize = currentMaxArraySize; }
                }
                else
                {
                    sum = 0;
                    startPoint = i+1;
                    currentMaxArraySize = 0;


                }
            }
        }
    }
}
