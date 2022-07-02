using System;
using System.Collections.Generic;
using static Graphs.BusinessTrips;

namespace Graphs
{
    class Program
    {
        public static void Main(string[] args)
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
            Console.WriteLine("****************************************************");
            Console.WriteLine("BreadthFirst :");

            //List<Vertex> path = graph.BreadthFirst(x);
            //Console.Write("Adjecency list of node A: ");
            //foreach (Vertex node in path)
            //{
            //    Console.Write($" {node.Value} ");
            //}
            //Graph graph = new Graph();
            graph.AddNode("Q");
            graph.AddNode("W");
            graph.AddNode("E");
            graph.AddNode("R");
            graph.AddNode("T");
            graph.AddNode("Y");
            Vertex Q = new Vertex("Q");
            Vertex W = new Vertex("W");
            Vertex E = new Vertex("E");
            Vertex R = new Vertex("R");
            Vertex T = new Vertex("T");
            Vertex Y = new Vertex("Y");
            graph.AddEdge(Q, W, 11);
            graph.AddEdge(W, E, 3);
            graph.AddEdge(E, R, 4);
            graph.AddEdge(R, T, 5);
            graph.AddEdge(T, Y, 77);
            graph.AddEdge(R, T, 32);
            graph.AddEdge(T, Y, 16);

            List<Vertex> path = graph.BreadthFirst(Q);
            Console.Write("starting frome Q orfed by BreadthFirst : ");
            foreach (Vertex xx in path)
            {
                Console.Write($" {xx.Value} ");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            

            Console.WriteLine("BusinessTrip :");
            Graph travil = new Graph();
            travil.AddNode("amman");
            travil.AddNode("irbid");
            travil.AddNode("dubai");
            travil.AddNode("ah qahira");
            travil.AddNode("qatar");
            Vertex A = new Vertex("amman");
            Vertex B = new Vertex("irbid");
            Vertex C = new Vertex("dubai");
            Vertex D = new Vertex("ah qahira");
            Vertex AE = new Vertex("qatar");
            travil.AddEdge(A, B, 40);
            travil.AddEdge(A, C, 13);
            travil.AddEdge(B, C, 55);
            travil.AddEdge(C, D, 4);
            travil.AddEdge(C, AE, 122);
            travil.AddEdge(D, AE, 62);
            //string start = "irbid";
            //string end = "qatar";
            string[] fromTo = { "amman", "irbid", "dubai" };
            var cc= BusinessTrip(travil, fromTo);
            Console.Write("the cost of the trip is ");
            Console.WriteLine(cc);

        }

        


    }
}
