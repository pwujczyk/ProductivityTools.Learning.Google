using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Learning.Google.Graph
{
    class DeephtFirst
    {
        UndirectedGraph Graph;
        private bool[] marked;
        private int[] edgeTo;

        public DeephtFirst(UndirectedGraph graph)
        {
            this.Graph = graph;
            marked = new bool[this.Graph.Edges.Length];
            edgeTo = new int [this.Graph.Edges.Length];
        }

        //tutaj powinienem przekazac w parametrze 0, poniewaz dla grafow rozlacznych nie zrobi przejscia
        public void DeepFirstSearchStep()
        {
            List<int> firstVertexEdges = Graph.Edges[0];
            marked[0] = true;
            edgeTo[0] = 0;
            DeepFirstSearchStep(0,firstVertexEdges);
      
        }

        public void DeepFirstSearchStep(int from, List<int> connections)
        {

            foreach (int connection in connections)
            {
                if (marked[connection] == false)
                {
                    marked[connection] = true;
                    edgeTo[connection] = from;
                    DeepFirstSearchStep(connection, Graph.Edges[connection]);
                }
            }
        }
    }
}
