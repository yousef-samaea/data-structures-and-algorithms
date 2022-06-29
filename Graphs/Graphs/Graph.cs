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


        public List<Vertex> BreadthFirst(Vertex vertex)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            Vertex root = Vertices.Find(n => n.Value == vertex.Value);
            List<Vertex> vertexPath = new List<Vertex>();
            
            root.Visited = true;
            queue.Enqueue(root);
            //root.Add(vertex);

            if (queue.Count == 0)
            {
                throw new Exception("its empty ther is no nods!!!");
            }

            while (queue.Count != 0)
            {
                Vertex front = queue.Dequeue();
                vertexPath.Add(front);
                foreach (Edge edge in front.Edge)
                {
                    if (!edge.Neighbor.Visited)
                    {
                        edge.Neighbor.Visited = true;
                        queue.Enqueue(edge.Neighbor);
                    }
                }
            }
            return vertexPath;
        }

       

    }
}
