using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.ShortestPaths.Graph
{
    class Cost
    {
        public int ToVertex;
        public double Weight;
    }

    class PriorityQuene : List<Cost>
    {

        public int GetSmallestToVertexWeight()
        {
            var min = double.MaxValue;
            Cost mintitem = null;
            foreach (var item in this)
            {
                if (item.Weight < min)
                {
                    min = item.Weight;
                    mintitem = item;
                }
            }
            this.Remove(mintitem);
            return mintitem.ToVertex;
        }

        public bool ContainsTo(int toVertex)
        {
            var x = this.Any(x => x.ToVertex == toVertex);
            return x;
        }

        public void DecreaseValueForKey(int toVertex, double value)
        {
            var key = this.Single(x => x.ToVertex == toVertex);
            key.Weight = value;
        }

        public void Insert(int ToVertex, double Weight)
        {
            var cost = new Cost();
            cost.ToVertex = ToVertex;
            cost.Weight = Weight;
            this.Add(cost);
        }

    }
}
