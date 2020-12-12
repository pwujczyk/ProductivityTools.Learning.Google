using ProductivityTools.Learning.Google.Graph.Dijkstra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.Learning.Google.ShortestPaths.Graph
{
    class Dijkstra
    {
        private DirectedEdge[] edgeTo;
        private double[] distTo;
        private PriorityQuene priorityQuene;

        public Dijkstra(EdgeWeigthDigrapth edgeWeigthDigrapth, int start)
        {
            this.edgeTo = new DirectedEdge[edgeWeigthDigrapth.Size];
            this.distTo = new double[edgeWeigthDigrapth.Size];
            this.priorityQuene = new PriorityQuene();


            for (int i = 0; i < edgeWeigthDigrapth.Size; i++)
            {
                distTo[i] = double.PositiveInfinity;
            }

            distTo[start] = 0;
            this.priorityQuene.Insert(start, 0);
            while (priorityQuene.Count > 0)
            {
                int v = priorityQuene.RemoveMin();
                foreach (DirectedEdge edge in edgeWeigthDigrapth.Vertexes[v])
                {
                    Relax(edge);
                }
            }
        }

        private void Relax(DirectedEdge edge)
        {
            int from = edge.From, to = edge.To;
            if (distTo[to] > distTo[from] + edge.Weight)
            {
                distTo[to] = distTo[from] + edge.Weight;
                edgeTo[to] = edge;
                if (this.priorityQuene.ContainsTo(to))
                {
                    priorityQuene.DecreaseValueForKey(to, distTo[to]);
                }
                else
                {
                    this.priorityQuene.Insert(to,distTo[to]);
                }
            }
        }
    }
}
