using ProductivityTools.Learning.Google.A1.QuickFind;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProductivityTools.Learning.Google.Kruskal
{
    public class KruskalAlghorithm
    {
        PriorityQuene PriorityQuene = new PriorityQuene();
        List<Edge> EdgeTo = new List<Edge>();

        public KruskalAlghorithm(Graph g)
        {
            foreach(var edge in g.Edges)
            {
                this.PriorityQuene.Add(edge);
            }

            QuickUnionAlghoritm quickUnion = new QuickUnionAlghoritm(g.Size);

            while (PriorityQuene.Length > 0 && this.EdgeTo.Count<g.Size-1)
            {
                Edge e = this.PriorityQuene.RemoveSmallestEdge();
                if(quickUnion.Connected(e.From,e.To)==false)
                {
                    quickUnion.Union(e.From, e.To);
                    this.EdgeTo.Add(e);
                }
            }
        }
    }
}
