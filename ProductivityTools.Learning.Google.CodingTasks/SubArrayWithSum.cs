using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    public static class SubArrayWithSum
    {
        static int maxSubArraySum(int[] a)
        {
            int max_so_far = int.MinValue,
            max_ending_here = 0, start = 0,
            end = 0, s = 0;

            for (int i = 0; i < a.Length; i++)
            {
                max_ending_here += a[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }
            return (end - start + 1);
        }

        // Driver code 
        public static void Do()
        {
            int[] a = { 20, 20, -1, 42, };
            var r = maxSubArraySum(a);
            Console.Write(r);
        }
    }
}
