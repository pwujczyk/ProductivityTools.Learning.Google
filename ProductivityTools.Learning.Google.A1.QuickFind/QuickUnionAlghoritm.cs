using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    class QuickUnionAlghoritm:Base
    {
        public QuickUnionAlghoritm(int n) : base(n) { }


        public override void Union(int from, int to)
        {
            table[from] = table[to];
        }


        private int FindRoot(int a)
        {
            while(table[a]!=a)
            {
               return FindRoot(table[a]);
            }
            return a;
        }

        public override bool Connected(int a, int b)
        {
            int parenta = FindRoot(a);
            int parentb = FindRoot(b);
            if (parenta==parentb)
            {
                return true;
            }
            {
                return false;
            }
        }
    }
}
