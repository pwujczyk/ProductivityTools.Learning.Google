using System;

namespace ProductivityTools.Learning.Google.MST
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdge(new Edge(0, 1,0.1));
            g.AddEdge(new Edge(0, 4,0.2));
            g.AddEdge(new Edge(1, 2,0.4));
            g.AddEdge(new Edge(2, 3,0.5));
            g.AddEdge(new Edge(1, 4,0.3));
            MST mST = new MST(g);

  Console.WriteLine("Hello World!");
        }
    }
}
