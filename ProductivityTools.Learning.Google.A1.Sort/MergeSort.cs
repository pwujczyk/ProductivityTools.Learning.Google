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
            this.Print();

            int leftIterator = start;
            int rightIterator = middle;
            int resultIterator = start;

            while (resultIterator <= end) //?
            {
                
        }


            // int low = start;
            // int high = end;


            //int x = low, y = middle + 1; 

            //for (int i = start; i <= end; i++)
            //{
            //    if (x > middle)
            //    {
            //        this.A1[i] = this.A2[y];
            //        y++;
            //    }
            //    else if (y > high)
            //    {
            //        this.A1[i] = this.A2[x];
            //        x++;
            //    }
            //    else if (this.A2[x] > this.A2[y])
            //    {
            //        this.A1[i] = this.A2[y];
            //        y++;
            //    }
            //    else
            //    {
            //        this.A1[i] = this.A2[x];
            //        x++;
            //    }
            //}
            this.Print();
        }

        public void Sort(int start, int end)
        {
            // this.Print();
           // Console.WriteLine($"{start} - {end}");
            if (start == end) { return; }
            int middle = (start + end) / 2;
            Sort(start, middle);
            Sort(middle + 1, end);
            Merge(start, middle, end);
        }

        public void Sort(int[] a)
        {
            this.A1 = a;
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    this.A1[i] = 9 - i;
            ////}
            //this.A1[0] = 9;
            //this.A1[1] = 5;
            //this.A1[2] = 5;
            //this.A1[3] = 5;
            //this.A1[4] = 6;
            //this.A1[5] = 9;
            //this.A1[6] = 2;
            //this.A1[7] = 5;
            //this.A1[8] = 4;
            //this.A1[9] = 2;


            this.A2 = new int[this.A1.Length];

            Sort(0, a.Length - 1);
        }

        void Print()
        {
            for (int i = 0; i < this.A1.Length; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            foreach (var item in this.A1)
            {
                Console.Write(item);
            }
            // Console.WriteLine();
            //foreach (var item in this.A2)
            //{
            //    Console.Write(item);
            //}
            Console.WriteLine();
        }
    }
}
