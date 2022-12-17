using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    internal class QuickSort2_Traiing
    {

        private void Sort(int[] array, int low, int top)
        {
            int left = low;
            int right = top;
            int partition = array[(left + right) / 2];

            while (left < right)
            {
                while (array[left] < partition) { left++; }
                while (partition < array[right]) { right--; }
                if (left < right)
                {
                    //swap
                }
            }
            Sort(array, low, left);
            Sort(array, right, top);
    }
}
