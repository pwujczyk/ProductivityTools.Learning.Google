using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    internal class QuickSort2 : ISort
    {
        private void Sort(int[] array, int bottom, int top)
        {
            var left = bottom;
            var right = top;
            var pivot = array[(bottom + top) / 2];
            while (left < right)
            {
                while (array[left] < pivot) left++;
                while (array[right] > pivot) right--;
                if (left <= right)
                {
                    // swap
                    var tmp = array[left];
                    array[left++] = array[right];  // ++ and -- inside array braces for shorter code
                    array[right--] = tmp;
                }
            }
            if (bottom < right) Sort(array, bottom, right);
            if (left < top) Sort(array, left, top);
        }
    
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
    }
}
