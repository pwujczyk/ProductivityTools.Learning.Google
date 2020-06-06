using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class DirectedGraph
    {
        private int V;
        public List<int>[] adj;

        public DirectedGraph(int v)
        {
            this.V = v;
            this.adj = new List<int>[v];
            for (int i = 0; i < V; i++)
            {
                this.adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);//jedyna roznica w stosunku do undirected
        }
    }
}
