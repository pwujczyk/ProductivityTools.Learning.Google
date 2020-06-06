using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.MST
{
    public class Edge
    {
        public int V { get; set; }
        public int W { get; set; }
        public Double Weight { get; set; }
        public Edge(int v, int w, double weight)
        {
            this.V = v;
            this.W = v;
            this.Weight = weight;
        }
    }
}
