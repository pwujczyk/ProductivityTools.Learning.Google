using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    public abstract class  Base
    {
        protected int[] table;

        public Base(int n)
        {
            table = new int[n];
            for (int i = 0; i < n; i++)
            {
                table[i] = i;
            }
        }

        public void PrintTable()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"Index:{i},value:[{table[i]}]");
            }
        }

        public abstract bool Connected(int a, int b);
        public abstract void Union(int from, int to);

    }
}
