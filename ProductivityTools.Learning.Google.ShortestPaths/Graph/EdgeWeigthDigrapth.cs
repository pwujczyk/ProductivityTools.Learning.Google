using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph.Dijkstra
{
    class EdgeWeigthDigrapth
    {
        List<DirectedEdge>[] Vertexes;
        public int Size => Vertexes.Length;

        public EdgeWeigthDigrapth(int vertexes)
        {
            this.Vertexes = new List<DirectedEdge>[vertexes];
            for (int i = 0; i < vertexes; i++)
            {
                this.Vertexes[i] = new List<DirectedEdge>();
            }
        }

        public void AddEdge(DirectedEdge edge)
        {
            int vertex = edge.From;
            Vertexes[vertex].Add(edge);
        }
    }
}
