using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        private Vertex x;

        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        public Object AddNode(Object value)
        {
            Vertex vertex = new Vertex(value);
            Vertices.Add(vertex);
            return vertex;
        }

        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
        {
            if (vertA == vertB)
            {
                x = Vertices.Find(v => v.Value == vertA.Value);
                Vertex pointTo = x;
                Edge edge = new Edge(pointTo, weight);
                Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edge);
                return;
            }

            Vertex pointA = Vertices.Find(v => v.Value == vertA.Value);
            Vertex pointB = Vertices.Find(v => v.Value == vertB.Value);

            Edge edgeA = new Edge(pointB, weight);
            pointA.Edge.Add(edgeA);

            Edge edgeB = new Edge(pointA, weight);
            pointB.Edge.Add(edgeB);
        }

        public List<Vertex> GetNodes()
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        }

        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        }


        public int Size()
        {
            return Vertices.Count;
        }
        
    }
}
