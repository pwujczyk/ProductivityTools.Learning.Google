using System;

namespace ProductivityTools.Learning.Google.Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 4);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(1, 4);
            g.AddEdge(2, 3);

            DeephtFirst dp = new DeephtFirst(g);
            dp.DeepFirstSearchStep();

            BreathFirst bf = new BreathFirst(g);
            bf.BreathFirstStep();
        }
    }
}
