using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Prim
{
    class PrimAlghorytm
    {

        PriorityQuene PriorityQuene = new PriorityQuene();
        List<Edge> MST = new List<Edge>();
        bool[] Marked;
        Graph Graph;

        public PrimAlghorytm(Graph graph)
        {
            this.Graph = graph;
            this.Marked = new bool[graph.Size];
            Visit(0);

            while (this.PriorityQuene.Length > 0)
            {
                Edge edge = this.PriorityQuene.RemoveSmallestEdge();
                if (this.Marked[edge.From] == false || this.Marked[edge.To] == false)
                {
                    MST.Add(edge);
                    if (this.Marked[edge.From] == false) { Visit(edge.From); }
                    if (this.Marked[edge.To] == false) { Visit(edge.To); }
                }
            }
        }

        public void Visit(int v)
        {
            this.Marked[v] = true;
            foreach (var edge in this.Graph.Vertex[v])
            {
                if (this.Marked[edge.To] == false)
                {
                    this.PriorityQuene.Add(edge);
                }
            }
        }

    }
}
