using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    internal class QuickSort
    {
        //https://code-maze.com/csharp-quicksort-algorithm/
        private void Sort(int[] array, int low, int high)
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
                }
                while (array[partitionPoint] < array[rightIterator])
                {
                    rightIterator--;
                }

                if (leftIterator <= rightIterator)
                {
                    swap(leftIterator, rightIterator);
                    leftIterator++;
                    rightIterator--;
                }
               
            }
            if (low < rightIterator)
                Sort(array, low, rightIterator);
            if (leftIterator < high)
                Sort(array, leftIterator, high);
        }


        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
    }
}
