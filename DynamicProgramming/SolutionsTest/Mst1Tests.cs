using Solutions.Graphs.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SolutionsTest
{
    public class Mst1Tests
    {
        [Fact]
        public void BasicTest()
        {
            //all tests follow a specific format - arrange (all required inputs), act (by calling the main composed method on the class), and assert (make sure the output you get, is the output you expect 

            //arrange / setup inputs
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);

            //so you can use {} object initializer syntax in C# to call the default constructor and provide values for properties and fields that have public or internal set
            var edge1 = new Edge
            {
                Vertex1 = v1,
                Vertex2 = v2,
                Weight = 5
            };
            var edge2 = new Edge
            {
                Vertex1 = v2,
                Vertex2 = v3,
                Weight = 6
            };
            var edge3 = new Edge
            {
                Vertex1 = v3,
                Vertex2 = v4,
                Weight = 2
            };
            var edge4 = new Edge
            {
                Vertex1 = v4,
                Vertex2 = v6,
                Weight = 2
            };
            var edge5 = new Edge
            {
                Vertex1 = v6,
                Vertex2 = v1,
                Weight = 1
            };
            var edge6 = new Edge
            {
                Vertex1 = v5,
                Vertex2 = v2,
                Weight = 2
            };
            var edge7 = new Edge
            {
                Vertex1 = v5,
                Vertex2 = v1,
                Weight = 4
            };
            var edge8 = new Edge
            {
                Vertex1 = v5,
                Vertex2 = v6,
                Weight = 10
            };
            var edge9 = new Edge
            {
                Vertex1 = v5,
                Vertex2 = v3,
                Weight = 3
            };

            //also use OI here
            var edges = new List<Edge>
            {
                edge1,
                edge2,
                edge3,
                edge4,
                edge5,
                edge6,
                edge7,
                edge8,
                edge9,
            };

            //if product code does not resolve, such as IGraph, use yellow-bulb
            IGraph graph = new Graph
            {
                Edges = edges,
            };


            //act

            var vertices = graph.Mst();

            //assert - make sure what you get is what you expect

            //find v1
            Assert.True(v1.Leader == v6);
            Assert.True(v3.Leader == v4);
        }
    }
}
