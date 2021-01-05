using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class MergeSort : ISort
    {
        int[] A1;
        int[] A2;

        public void Merge(int start, int middle, int end)
        {
            for (int i = 0; i < this.A1.Length; i++)
            {
                this.A2[i] = this.A1[i];
            }

            int leftIterator = start, rightIterator = middle + 1;

            for (int i = start; i <= end; i++)
            {
                if (leftIterator > middle)
                {
                    this.A1[i] = this.A2[rightIterator];
                    rightIterator++;
                }
                else if (rightIterator > end)
                {
                    this.A1[i] = this.A2[leftIterator];
                    leftIterator++;
                }
                else if (this.A2[leftIterator] > this.A2[rightIterator])
                {
                    this.A1[i] = this.A2[rightIterator];
                    rightIterator++;
                }
                else
                {
                    this.A1[i] = this.A2[leftIterator];
                    leftIterator++;
                }
            }
        }

        public void Sort(int start, int end)
        {
            if (start == end) { return; }
            int middle = (start + end) / 2;
            Sort(start, middle);
            Sort(middle + 1, end);
            Merge(start, middle, end);
        }

        public void Sort(int[] a)
        {
            Sort(0, a.Length - 1);
        }
    }
}
