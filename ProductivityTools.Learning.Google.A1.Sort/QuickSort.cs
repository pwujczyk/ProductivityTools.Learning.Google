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

            int partitionPoint = low;
            int leftIterator = low + 1;
            int rightIterator = high;

            while (true)
            {
                while (a[leftIterator] < a[partitionPoint])
                {
                    leftIterator++;
                    if (leftIterator >= high) break;
                }

                while (a[partitionPoint] < a[rightIterator])
                {
                    rightIterator--;
                    if (leftIterator == low) break;
                }

                if(leftIterator>=rightIterator)
                {
                    break;
                }

                swap(leftIterator, rightIterator);
                leftIterator++;
                rightIterator--;
            }
            swap(low,rightIterator);
            return leftIterator;
        }

        public void Sort(int[] a, int low, int high)
        {
            if(low>=high) { return; }
            int partitionPoint = Partition(a, low, high);

            Sort(a, 0, partitionPoint-1);//?-1
            Sort(a, partitionPoint + 1, high);
        }

        public void Sort(int[] a)
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
        }
    }
}
