using System;

namespace ProductivityTools.Learning.Google.Kruskal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph g = new Graph(5);
            g.AddEdge(new Edge(0, 1, 22));
            g.AddEdge(new Edge(1, 2, 11));
            g.AddEdge(new Edge(0, 2, 44));
            g.AddEdge(new Edge(2, 3, 1));
            g.AddEdge(new Edge(1, 4, 66));
            g.AddEdge(new Edge(3, 4, 55));

            KruskalAlghorithm k = new KruskalAlghorithm(g);
            
        }
    }
}
