using Graphs;
using System;
using System.Collections.Generic;
using Xunit;
namespace TestBusines
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
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
            var cc = BusinessTrips.BusinessTrip(travil, fromTo);
            //var x = BusinessTrips.BusinessTrip(travil, start, end);
            Assert.Equal(cc, BusinessTrips.BusinessTrip(travil, fromTo));

        }




    }
}
