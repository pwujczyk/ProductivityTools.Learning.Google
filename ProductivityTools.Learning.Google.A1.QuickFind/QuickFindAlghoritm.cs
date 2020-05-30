using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    class QuickFindAlghoritm : Base
    {

        public QuickFindAlghoritm(int m) : base(m)
        { }

        public override void Union(int from, int to)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == table[from])
                {
                    table[from] = table[to];
                }
            }
        }

        public override bool Connected(int a, int b)
        {
            if (table[a] == table[b])
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
