using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class DeephtFirst
    {
        Graph g;
        private bool[] marked;
        private int[] edgeTo;

        public DeephtFirst(Graph graph)
        {
            this.g = graph;
            marked = new bool[this.g.adj.Length];
            edgeTo = new int [this.g.adj.Length];
        }

        public void DeepFirstSearchStep()
        {
            List<int> vertex = g.adj[0];
            marked[0] = true;
            edgeTo[0] = 0;
            DeepFirstSearchStep(0,vertex);
      
        }

        public void DeepFirstSearchStep(int from, List<int> connections)
        {

            foreach (int connection in connections)
            {
                if (marked[connection]) { continue; }
                marked[connection] = true;
                edgeTo[connection] = from;
                DeepFirstSearchStep(connection, g.adj[connection]);
            }
        }
    }
}
