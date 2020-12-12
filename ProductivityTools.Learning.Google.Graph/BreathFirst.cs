using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class BreathFirst
    {
        UndirectedGraph Graph;
        Queue<int> Queue = new Queue<int>();
        bool[] visited;
        int[] from;

        public BreathFirst(UndirectedGraph g)
        {
            this.Graph = g;
            from = new int[g.Edges.Length];
            visited = new bool[g.Edges.Length];
            int startVertex = 0;
            BreathFirstStep(startVertex);
        }

        public void BreathFirstStep(int node)
        {
            this.visited[node] = true;
            this.from[node] = 0;
            this.Queue.Enqueue(node);
            while(this.Queue.Count>0)
            {
                int vertex = this.Queue.Dequeue();
                foreach (int item in this.Graph.Edges[vertex])
                {
                    if(this.visited[item]==false)
                    {
                        this.Queue.Enqueue(item);
                        this.visited[item] = true;
                        this.from[item] = vertex;
                    }
                }
            }
        }
    }
}
