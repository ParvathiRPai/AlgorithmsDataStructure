using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Graphs.Trees
{
    //you have a graph (adjacency list)
    //you have to create a MST
    //greedy algorithm - you know that it is always safe to pick the least weight / shortest edge, SO LONG AS it does not create a cycle
    //you detect a cycle if they have the same leader
    //to pick the least weight edge, you have to sort
    //you can use the inbuilf IList.Sort or write your own
    //when you pick an edge, and compare the leaders, and find they are different, you have to update the leader of the vertex who lost - because every sub-graph can have only 1 leader
    //if both vertices fo the edge have the same leader, we ignore - refer above regarding cycle
    //once you have exhausted all edges, the resulting subgraph does not have any cycles, also all vertices are connected - any acyclic connected undirected graph is a tree - the tree need not be binary - because there can be more than 2 edges coming out of it, and since it is undirected, there is no concept of a parent
    
    //1 - define objects

    //all classes are best public or internal, unless they are not intended to be tested
    public class Vertex : BasicVertex
    {
        //this vertex data could be here, but is now inherited from BasicVertex
        //public int Data { get; }
        //creates an empty adjacency list, which shall be populated later
        public IList<Vertex> AdjacencyList = new List<Vertex>();

        public Vertex Leader { get; set; }
        //all classes need a constructor - C# by default provides a constructor without arguments/param, PROVIDED you have not created a constructor like this
        public Vertex(int data)
        {
            this.Data = data;
            this.Leader = this;
        }

        //this is how the adjaency list will be populated in the test
        public void AddToAdjacencyList(Vertex v)
        {
            AdjacencyList.Add(v);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public int Weight { get; set; }

        //here we are teaching C# that when we compare 2 edges (comparisons can be used for anything, but are often used for sorting), we only care about the weight and not other properties / fields
        public int CompareTo(Edge other)
        {
            return this.Weight.CompareTo(other.Weight);
            //the following is what the above does
            //if(this.Weight < other.Weight)
            //{
            //    //this is less than the other edge
            //    return -1;
            //}
            //else if(this.Weight > other.Weight)
            //{
            //    //this is greater than the other edge
            //    return 1;
            //}

            ////both edges are equivalent
            //return 0;
        }

        //you could define a constructor like this, but there is a way to use C#'s default constructor for 'object initializers'
        //public Edge(Vertex v1, Vertex v2, int weight)
        //{
        //    Vertex1 = v1;
        //    Vertex2 = v2;
        //    Weight = weight;
        //}
    }

    //start with defining an interface to define what public methods will be supported by your implementations 
    public interface IGraph
    {
        //note that the following should be in the class, interface only has methods defined
        //public IList<Vertex> Vertices = new List<Vertex>();

        //to join vertices, we need to find their leader, to select the vertices, we need the shortest edge currently, to get the shortest edge, we need to sort, but the class only has edges, so we need to create vertices from the edges 
        void Sort();
        IList<Vertex> ConstructVerticesFromEdges(IList<Edge> edges);
        Vertex GetLeader(Vertex v);
        //try-xyz is the general naming convention for something that might succeed and return true, but in all other cases - might not even do something /fail it will return false
        bool TryMerge(Vertex v1, Vertex v2);
        //this is the actual call that will first sort, then construct vertices, then one-by-one merge them, till there is only 1 leader - this is called composition, a more compex method, includes smaller but critical components
        //if you were not testing Mst can be void, but to check the assert part, you need to return the vertices so we can verify leaders
        IList<Vertex> Mst();
    }

    //to auto-implement interface, use yellow-bulb
    public class Graph :IGraph
    {
        //start with the most simple
        public IList<Edge> Edges = new List<Edge>();

        public Graph()
        {
        }

        public IList<Vertex> ConstructVerticesFromEdges(IList<Edge> edges)
        {
            //maintain a hashset to return all vertices
            HashSet<Vertex> vertices = new HashSet<Vertex>();
            foreach(var edge in edges)
            {
                var v1 = edge.Vertex1;
                var v2 = edge.Vertex2;
                v1.AddToAdjacencyList(v2);
                v2.AddToAdjacencyList(v1);
                //add to vertices if they are not there already
                if(!vertices.Contains(v1))
                {
                    vertices.Add(v1);
                }
                if (!vertices.Contains(v1))
                {
                    vertices.Add(v1);
                }
            }

            //a hashset is an O(1) set, but all sets can be converted to lists using ToList()
            return vertices.ToList();
        }

        public Vertex GetLeader(Vertex v)
        {
            //this requires that the Vertex has a leader set, so augment the Vertex to add an internal leader and in the constructor, initialize it to itself
            //then, go up the leader chain, till a vertex only points to itself, which has to be the top leader of the group
            //whenever you use a while loop or a for loop, make sure you do not change anything or update any existing data, so use temporary variables
            var temp = v;
            while(true)
            {
                if(temp.Leader == temp)
                {
                    return temp;
                }

                temp = temp.Leader;
            }
        }

        public void Sort()
        {
            //now by default, C# can sort lot of well known types, such as int, string etc. C# does not know how to sort custom types, such as Edge. You teach C# how to sort Edges by having Edge implement IComparable<Edge> and using yellow-bulb
            //a List class implements the IList interface, however, there are many other classes that also implement IList, but List is one of the only classes that has built-in sort, along with Arrays. So you need to tell C# that the type is not IList but List, by using ToList and yellow-bulb
            var tempList = Edges.ToList();
            tempList.Sort();
            Edges = tempList;
            //now edges has been sorted
        }

        public bool TryMerge(Vertex v1, Vertex v2)
        {
            //merging is easy since we have GetLeader
            var leaderV1 = GetLeader(v1);
            var leaderV2 = GetLeader(v2);
            if(v1 != v2)
            {
                if (leaderV1.Data <= leaderV2.Data)
                {
                    v1.Leader = leaderV2;
                    //intead of putting return true in all cases, put it outside them
                }
                else
                {
                    v2.Leader = leaderV1;
                }
                //here
                return true;
            }

            return false;
        }

        //the composition method should be moved last by convention
        public IList<Vertex> Mst()
        {
            //this return is not useful, only for illustration on how to get vertices from edges
            var vertices = ConstructVerticesFromEdges(Edges);
            Sort();
            //now iterate over edges (already sorted), and try to merge their vertices, if necessary
            foreach (var edge in Edges)
            {
                TryMerge(edge.Vertex1, edge.Vertex2);
            }

            return vertices;
        }
    }
}
