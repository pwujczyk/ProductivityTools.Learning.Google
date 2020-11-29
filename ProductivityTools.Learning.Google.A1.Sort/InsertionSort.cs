using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class InsertionSort : ISort
    {
        public void Sort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int j = i;
                while(j>0 && a[j-1]>a[j])
                {
                    var temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                    j--;
                }
            }

        }
    }
}
