using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    class WightQuickUnion : Base
    {
        public WightQuickUnion(int n) : base(n)
        {
        }

        private int FindRoot(int a)
        {
            while (table[a] != a)
            {
                return FindRoot(table[a]);
            }
            return a;
        }

        public override bool Connected(int a, int b)
        {
            int parenta = FindRoot(a);
            int parentb = FindRoot(b);
            if (parenta == parentb)
            {
                return true;
            }
            {
                return false;
            }
        }

        public override void Union(int from, int to)
        {
           
        }
    }
}
