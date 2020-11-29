using ProductivityTools.Learning.Google.Graph.Dijkstra;
using System;
using System.Linq.Expressions;

namespace ProductivityTools.Learning.Google.ShortestPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EdgeWeigthDigrapth edgeWeigthDigrapth = new EdgeWeigthDigrapth(5);

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 5, 2));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 3, 3));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 2, 1));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 3, 5));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 4, 8));

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 3, 5));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 4, 8));


            int startpoint = 0;
            ShortestPath sp = new ShortestPath(edgeWeigthDigrapth, startpoint);
            for (int i = 0; i < edgeWeigthDigrapth.Size; i++)
            {
                Console.WriteLine($"Distance from{startpoint} to {i} is {sp.distTo(i)}");
            }
        }
    }
}
