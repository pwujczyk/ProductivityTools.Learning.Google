using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class ShellSort : ISort
    {
        public int Sort(int[] a)
        {
            int result = 0;
            int n = a.Length;
            int h = 1;
            while (h < n / 3)
            {
                h = 3 * h - 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    int j = i;
                    while (j >= h && a[j] < a[j - h])
                    {
                        result++;
                        var temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                        j = j - h;
                    }
                }
                h = h / 3;
            }

            return result;
        }
    }
}
