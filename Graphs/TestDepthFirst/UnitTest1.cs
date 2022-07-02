using Graphs;
using System;
using System.Collections.Generic;
using Xunit;


namespace TestDepthFirst
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graph graph = new Graph();

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

            List<Vertex> results = Graph.DepthFirst(graph);
            object[] result = new object[6];
            int i = 0;
            foreach (var xx in result)
            {
                result[i] = results[i].Value;
                i++;
            }
            object[] expected = { "Q", "W", "E", "R", "T", "Y" };
            //object[] expected = { "Y", "T", "R", "E", "W", "Q" };

            Assert.Equal(expected, result);
        }
    }
}
