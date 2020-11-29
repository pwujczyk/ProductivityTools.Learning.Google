using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.PriorityQuene
{
    public class PriorityQuene:List<int>
    {
        private readonly int Max;

        public PriorityQuene(int max)
        {
            this.Max = max;
        }

        public int RemoveMin()
        {
            var x = this.Min();
            this.Remove(x);
            return x;
        }

        internal void AddMax(int z)
        {
            if(this.Count>Max)
            {
                //sort by insert for example
                //isnert if greater
            }
         

        }
    }
}
