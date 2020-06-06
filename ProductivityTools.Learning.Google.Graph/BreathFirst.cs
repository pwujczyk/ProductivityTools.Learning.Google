using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class BreathFirst
    {
        Graph Graph;
        Queue<int> Queue = new Queue<int>();
        bool[] visited;
        int[] from;

        public BreathFirst(Graph g)
        {
            this.Graph = g;
            from = new int[g.adj.Length];
            visited = new bool[g.adj.Length];

        }

        public void BreathFirstStep()
        {
            int node = 0;
            var connections=this.Graph.adj[node];
            this.visited[node] = true;
            this.from[node] = 0;
            this.Queue.Enqueue(node);
            while(this.Queue.Count>0)
            {
                int v = this.Queue.Dequeue();
                foreach (int item in this.Graph.adj[v])
                {
                    if(this.visited[item]==false)
                    {
                        this.Queue.Enqueue(item);
                        this.visited[item] = true;
                        this.from[item] = v;
                    }
                }
            }
        }
    }
}
