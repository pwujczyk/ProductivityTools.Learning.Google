using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Learning.Google.MST
{
    class MST
    {
        Graph graph;
        private Queue<Edge> mst = new Queue<Edge>();

        public MST(Graph g)
        {
            Queue<Edge> quene = new System.Collections.Generic.Queue<Edge>();
            //tu mołbym dac priority quene
            foreach (var edge in g.Edges.OrderBy(x=>x.Weight))
            {
                quene.Enqueue(edge);
            }

            while (quene.Count > 0 && mst.Count < g.Edges.Count - 1) 
            {
                var edge = quene.Dequeue();
               // if (mst.Contains())

            }
        }
    }
}
