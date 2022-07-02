using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class BusinessTrips : Graph
    {
        public static int? BusinessTrip(Graph graph, string[] arr)
        {
            int Cost = 0;
            if (arr.Length <= 1)
            {
                return null;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                List<Edge> Edges = graph.GetNeighbors(new Vertex(arr[i]));

                if (!Edges.Exists(n => n.Neighbor.Value.ToString() == arr[i + 1]))
                {
                    return null;
                }
                else
                {
                    Cost += Edges.Find(n => n.Neighbor.Value.ToString() == arr[i + 1]).Weight;
                }
            }
            return Cost;
        }
    }
}
