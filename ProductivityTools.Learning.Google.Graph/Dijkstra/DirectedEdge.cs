using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace ProductivityTools.Learning.Google.Graph.Dijkstra
{
    class DirectedEdge
    {
        public int From, To;
        public  double Weight;

        public DirectedEdge(int from, int to, double weight)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }

  
    }
}
