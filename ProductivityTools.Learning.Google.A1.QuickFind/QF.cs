using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    class QF
    {
        private int[] objects;

        public QF(int n)
        {
            objects= new int[n];
            for (int i = 0; i < n; i++)
            {
                objects[i] = i;
            }
        }

        public void Union(int from, int to)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if(objects[i]==objects[from])
                {
                    objects[from] = objects[to];
                }
            }
        }


        public void PrintTable()
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine($"Index:{i},value:[{objects[i]}]");
            }
        }

        public bool Connected(int a, int b)
        {
            if (objects[a]==objects[b])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
