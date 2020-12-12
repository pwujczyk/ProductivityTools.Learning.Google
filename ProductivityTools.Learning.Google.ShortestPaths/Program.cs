using ProductivityTools.Learning.Google.Graph.Dijkstra;
using ProductivityTools.Learning.Google.ShortestPaths.Graph;
using System;
using System.Linq.Expressions;

namespace ProductivityTools.Learning.Google.ShortestPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EdgeWeigthDigrapth edgeWeigthDigrapth = new EdgeWeigthDigrapth(6);

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 5, 2));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 3, 3));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(1, 2, 1));

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 3, 5));
            edgeWeigthDigrapth.AddEdge(new DirectedEdge(2, 4, 8));

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(5, 3, 4));

            edgeWeigthDigrapth.AddEdge(new DirectedEdge(3, 4, 5));


            int startpoint = 0;
            //ShortestPath sp = new ShortestPath(edgeWeigthDigrapth, startpoint);
            //for (int i = 0; i < edgeWeigthDigrapth.Size; i++)
            //{
            //    Console.WriteLine($"Distance from{startpoint} to {i} is {sp.distTo(i)}");
            //}

            Dijkstra d = new Dijkstra(edgeWeigthDigrapth, 1);
        }
    }
}
