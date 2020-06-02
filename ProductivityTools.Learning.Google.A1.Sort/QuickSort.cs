using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class QuickSort : ISort
    {
        private int Partition(int[]a, int low, int high)
        {
            Action<int, int> swap = (x, y) =>
               {
                   int temp = a[x];
                   a[x] = a[y];
                   a[y] = temp;
               };
            //324243242
            //012___345
            //xxx<3<xxx

            //32424324
            //low=0;high=8

            int p = low;//partition point//3
            int i = low + 1;
            int j = high;

            while (true)
            {
                while (a[ i] < a[p])
                {
                    i++;
                    if (i >= high) break;
                }

                while (a[p] < a[j])
                {
                    j--;
                    if (i == low) break;
                }

                if(i>=j)//?>=
                {
                    break;
                }

                swap(i, j);
                i++;
                j--;
            }
            swap(low,j);
            return i;
        }

        public void Sort(int[] a, int low, int high)
        {
            if(low>=high) { return; }
            int partitionPoint = Partition(a, low, high);

            Sort(a, 0, partitionPoint-1);//?-1
            Sort(a, partitionPoint + 1, high);
        }

        public int Sort(int[] a)
        {
            a[0] = 4;
            a[1] = 5;
            a[2] = 5;
            a[3] = 5;
            a[4] = 6;
            a[5] = 9;
            a[6] = 2;
            a[7] = 5;
            a[8] = 4;
            a[9] = 2;
            Sort(a, 0, a.Length - 1);

            return 1;
        }
    }
}
