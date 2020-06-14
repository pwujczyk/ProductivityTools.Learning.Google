using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class SelectionSort : ISort
    {
        public void Sort(int[] a)
        {
            
            int minposition = 0;
            int result = 0;
            bool swaped = true;
            while (swaped)
            {
                swaped = false;
                for (int i = minposition + 1; i < a.Length; i++)
                {
                    result++;
                    if (a[i] < a[minposition])
                    {
                        swaped = true;
                        int temp = a[minposition];
                        a[minposition] = a[i];
                        a[i] = temp;

                    }
                }
                minposition++; 
            }
        }
    }
}
