using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    internal class QuickSort
    {

        private int Sort(int[] array, int low, int high)
        {
            Action<int, int> swap = (x, y) =>
            {
                int temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            };

            int partitionPoint = low;
            int leftIterator = low+1;
            int rightIterator = high;

            while (leftIterator < rightIterator)
            {
                while (array[leftIterator] < array[partitionPoint])
                {
                    leftIterator++;
                    if (leftIterator >= high) break;
                }
                while (array[partitionPoint] < array[rightIterator])
                {
                    rightIterator--;
                    if (rightIterator == low) break;
                }
                swap(leftIterator, rightIterator);
                leftIterator++;
                rightIterator--;
            }
            swap(rightIterator, partitionPoint);
            return rightIterator;
        }

        private void Sort1(int[] array, int low, int high)
        {
            if (low >= high) return;
            int partitionPoint = Sort(array, low, high);
            Sort1(array, 0, partitionPoint-1);
            Sort1(array, partitionPoint+1, high);
        }


        public void Sort(int[] array)
        {
            Sort1(array, 0, array.Length - 1);
        }
    }
}
