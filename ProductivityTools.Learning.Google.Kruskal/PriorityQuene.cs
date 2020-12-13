using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Kruskal
{
    class PriorityQuene
    {
        List<Edge> Edges = new List<Edge>();

        public int Length
        {
            get
            {
                return this.Edges.Count;
            }
        }

        public void Add(Edge edge)
        {
            this.Edges.Add(edge);
        }

        internal Edge RemoveSmallestEdge()
        {
            var min = double.MaxValue;
            Edge mintitem = null;
            foreach (var item in this.Edges)
            {
                if (item.Weight < min)
                {
                    min = item.Weight;
                    mintitem = item;
                }
            }
            this.Edges.Remove(mintitem);
            return mintitem;
        }
    }
}
