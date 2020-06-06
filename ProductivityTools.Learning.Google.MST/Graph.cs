using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Learning.Google.MST
{
    class Graph
    {
        public List<Edge>[] Vertex;

        public Graph(int V)
        {
            this.Vertex = new List<Edge>[V];
            for (int i = 0; i < V; i++)
            {
                this.Vertex[i] = new List<Edge>();
            }

        }

        public void AddEdge(Edge e)
        {
            this.Vertex[e.V].Add(e);
            this.Vertex[e.W].Add(e);
        }

        public List<Edge> Edges
        {
            get
            {
                List<Edge> r = new List<Edge>();
                for (int i = 0; i < this.Vertex.Length; i++)
                {
                    r.AddRange(this.Vertex[i]);
                }
                return r;
            }
        }


    }
}
