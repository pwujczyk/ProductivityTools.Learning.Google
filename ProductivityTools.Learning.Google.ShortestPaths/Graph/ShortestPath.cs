using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph.Dijkstra
{
    class ShortestPath
    {
        EdgeWeigthDigrapth Graph;
        public ShortestPath(EdgeWeigthDigrapth graph, int startPoint)
        {
            this.Graph = graph;
        }

        public int distTo(int v)
        {
            for (int i = 0; i < Graph.Size; i++)
            {
                //brute force won't work, I don't know how to deal with circular
                foreach (var item in this.Graph.Vertexes[i])
                {
                    
                }
            }

            return -1;
        }
    }
}
