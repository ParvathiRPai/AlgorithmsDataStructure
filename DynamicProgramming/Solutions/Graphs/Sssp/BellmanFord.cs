using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Graphs.Sssp
{
    //supposed to work only with directed graphs
    public class Graph
    {
        private IList<Vertex> _vertices { get; set; }
        public IList<Edge> Edges { get; set; }

        internal IList<Vertex> GetVerticesFromEdges(IList<Edge> edges)
        {
            //vertexDict maps each vertex's data to that vertex, so that we can find that vertex if we find another edge that includes that vertex
            var vertexDict = new Dictionary<int, Vertex>();
            foreach(var edge in edges)
            {
                if(!vertexDict.ContainsKey(edge.Vertex1.Data))
                {
                    vertexDict[edge.Vertex1.Data] = edge.Vertex1;
                }

                //if there was the possibility, which you need the interviewer, of more than one edge between the same vertices, then you cannot just add that vertex to tha adjacency map, because it might already be there, in that case, you should take the least edge of what is there and the new edge
                vertexDict[edge.Vertex1.Data].AdjacencyVertexEdgeWeightMap.Add(edge.Vertex2, edge.Weight);

                //repeat for vertex 2 - WRONG - you do not add the other way because this is a direct graph
                //if (!vertexDict.ContainsKey(edge.Vertex2.Data))
                //{
                //    vertexDict[edge.Vertex2.Data] = edge.Vertex2;
                //}

                //vertexDict[edge.Vertex2.Data].AdjacencyVertexEdgeWeightMap.Add(edge.Vertex1, edge.Weight);
            }

            return vertexDict
                //select all values - here vertices
                .Select(x => x.Value)
                //return a list
                .ToList();
        }

        internal bool Relax(Vertex v1, Vertex v2, int weight)
        {
            //the below comparison can be inlined using he ? operator
            //bool hasRelaxed = false;
            //if(v2.Distance > v1.Distance + weight)
            //{
            //    hasRelaxed = true;
            //}

            var willRelax = v2.Distance > v1.Distance + weight ? true : false;
            v2.Distance = Math.Min(v1.Distance + weight, v2.Distance);

            return willRelax;
        }

        public void RunBellmanFord()
        {
            _vertices = GetVerticesFromEdges(Edges);
            //run this loop vertices.count times because there can at most be V-1 edges in any path (if there were more, then a vertex has been repeated, any path where a vertex is repeated has a cycle, and is no longer a shortest path)
            for (int i=0; i<_vertices.Count; i++)
            {
                bool hasAnyEdgeRelaxed = false;
                foreach(var edge in Edges)
                {
                    var relaxed = Relax(edge.Vertex1, edge.Vertex2, edge.Weight);
                    hasAnyEdgeRelaxed = hasAnyEdgeRelaxed || relaxed;
                }

                //minor optmization where we do not continue the loop if not even one edge was relaxed in this run
                if(!hasAnyEdgeRelaxed)
                {
                    break;
                }
            }
        }

    }

    public class Vertex : BasicVertex
    {
        //internal because Distance property is only needed for this algorithm
        internal int Distance { get; set; }
        //a map where each key-value pair is a vertex to the edge weight to that vertex
        public IDictionary<Vertex, int> AdjacencyVertexEdgeWeightMap = new Dictionary<Vertex, int>();
    }

    //unlike Mst1 - this wont need to implement IComparable<Edge> because it doesnt need to be sorted
    public class Edge
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public int Weight { get; set; }
    }
}
