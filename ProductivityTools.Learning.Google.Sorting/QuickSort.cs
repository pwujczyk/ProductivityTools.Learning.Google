using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    internal class QuickSort
    {

        private int Partition(int[] array, int low, int high)
        {
            Action<int, int> swap = (x, y) =>
            {
                int temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            };

            int partitionPoint = low;
            int leftIterator = low;
            int rightIterator = high;

            while (leftIterator < rightIterator)
            {
                while (array[leftIterator] < array[partitionPoint])
                {
                    leftIterator++;
                    if (high <= leftIterator) break;
                }
                while (array[partitionPoint] < array[rightIterator])
                {
                    rightIterator--;
                    if (rightIterator <= low) break;
                }
                //without it 01234 won't work, so whenwe will have leftiterator=0 and right iterator=0
                if (leftIterator < rightIterator)
                {
                    swap(leftIterator, rightIterator);
                }
                leftIterator++;
                rightIterator--;
            }
            swap(low, partitionPoint);
            return leftIterator;
        }

        private void Sort(int[] array, int low, int high)
        {
            if (low >= high) { return; }
            int partitionPoint = Partition(array, low, high);
            Sort(array, 0, partitionPoint - 1);
            Sort(array, partitionPoint + 1, high);
        }


        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
    }
}
