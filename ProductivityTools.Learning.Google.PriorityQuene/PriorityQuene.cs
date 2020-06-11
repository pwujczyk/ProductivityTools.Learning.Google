using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.PriorityQuene
{
    class PriorityQuene:List<int>
    {
        private readonly int Max;

        public PriorityQuene(int max)
        {
            this.Max = max;
        }

        public void RemoveMin()
        {
            var x = this.Min();
            this.Remove(x);
            
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
