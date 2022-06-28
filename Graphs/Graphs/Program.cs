using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode("x");
            graph.AddNode("y");
            graph.AddNode("z");
            graph.AddNode("q");

            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");

            Vertex x = new Vertex("x");
            Vertex y = new Vertex("y");
            Vertex z = new Vertex("z");
            Vertex q = new Vertex("q");
            graph.AddEdge(x, y, 15);
            graph.AddEdge(x, z, 7);
            graph.AddEdge(z, q, 4);

            Console.WriteLine("the Neighbors and weights of node x:");
            List<Edge> resultA = graph.GetNeighbors(x);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            Console.WriteLine("the Neighbors and weights of node z:");
            List<Edge> resultC = graph.GetNeighbors(z);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();


           
        }
    }
}
