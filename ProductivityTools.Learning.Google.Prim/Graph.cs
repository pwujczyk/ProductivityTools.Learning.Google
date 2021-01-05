using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.Prim
{
    public class Graph
    {
        public List<Edge>[] Vertex;

        public int Size
        {
            get
            {
                return this.Vertex.Length;
            }
        }

        public Graph(int size)
        {
            this.Vertex = new List<Edge>[size];
            for (int i = 0; i < size; i++)
            {
                this.Vertex[i] = new List<Edge>();
            }
        }

        public void AddEdge(Edge edge)
        {
            int vertex = edge.From;
            Vertex[vertex].Add(edge);
        }

        public IEnumerable<Edge> Edges
        {
            get
            {
                var result = new List<Edge>();
                for (int i = 0; i < this.Size; i++)
                {
                    result.AddRange(this.Vertex[i]);
                }

                var r = result.Distinct();
                return r;

            }
        }
    }
}
