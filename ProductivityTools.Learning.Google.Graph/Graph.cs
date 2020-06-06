using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class Graph
    {
        private int V;
        public List<int>[] adj;

        public Graph(int v)
        {
            this.V = v;
            this.adj = new List<int>[v];
            for (int i = 0; i < V; i++)
            {
                this.adj[i]=new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }
    }
}
