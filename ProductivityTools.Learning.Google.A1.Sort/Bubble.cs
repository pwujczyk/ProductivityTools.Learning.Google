﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class BubbleSort : ISort
    {
        public int Sort(int[] a)
        {
            int result = 0;
            bool correctOrder = false;
            while (correctOrder != true)
            {
                correctOrder = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    result++;
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                        correctOrder = false;
                    }
                }
            }
            return result;
        }
    }
}
