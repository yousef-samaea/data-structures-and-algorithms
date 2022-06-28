using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGraphs
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddNodeToGraph()
        {
            Graph graph = new Graph();
            Vertex node = (Vertex)graph.AddNode("vertices");
            Assert.Contains(node, graph.Vertices);
        }

        [Fact]
        public void TestAddedEdgeToGraph()
        {
            Graph graph = new Graph();
            Vertex x = (Vertex)graph.AddNode("x");
            Vertex y = (Vertex)graph.AddNode("y");
            
            graph.AddEdge(x, y, 8);
            Assert.NotEmpty(x.Edge);
        }

        [Fact]
        public void TestGetGraphNodesAsList()
        {
            Graph graph = new Graph();
            graph.AddNode("1");
            graph.AddNode("2");
            graph.AddNode("3");
            graph.AddNode("4");

            var list = graph.GetNodes();
            Assert.IsType<List<Vertex>>(list);
        }

        [Fact]
        public void TestGetNeighbors()
        {
            Graph graph = new Graph();
            Vertex x = (Vertex)graph.AddNode("x");
            Vertex y = (Vertex)graph.AddNode("y");
            Vertex z = (Vertex)graph.AddNode("z");
            graph.AddEdge(x, y, 8);
            graph.AddEdge(x, z, 12);
            var result = graph.GetNeighbors(x);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void NieghborNodesHaveWeight()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            graph.AddEdge(A, B, 9999);

            Edge[] result = graph.GetNeighbors(A).ToArray();

            Assert.Equal(9999, result[0].Weight);
        }

        [Fact]
        public void TestTheSizeOfGraph()
        {
            Graph graph = new Graph();
            graph.AddNode("x");
            graph.AddNode("y");
            graph.AddNode("z");

            int size = graph.Size();
            Assert.Equal(3, size);
        }
    }
}
