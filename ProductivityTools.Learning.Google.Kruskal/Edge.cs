using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Kruskal
{
    public class Edge
    {
        public int From, To;
        public double Weight;

        public Edge(int from, int to, double weight)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }
    }
}
