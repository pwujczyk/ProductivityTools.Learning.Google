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
                while (a[i] < a[p])
                {
                    i++;
                }

                while (a[p] < a[j])
                {
                    j--;
                }

                if(i>=j)//?>=
                {
                    break;
                }

                swap(a[i], a[j]);
            }
            swap(a[0], a[i]);
            return i;
        }

        public void Sort(int[] a, int low, int high)
        {
            int partitionPoint = Partition(a, low, high);

            Sort(a, 0, partitionPoint);//?-1
            Sort(a, partitionPoint + 1, high);
        }

        public int Sort(int[] a)
        {
            Sort(a, 0, a.Length - 1);

            return 1;
        }
    }
}
