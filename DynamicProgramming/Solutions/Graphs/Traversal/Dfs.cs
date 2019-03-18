using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Graphs.Traversal
{
    public enum DfsEdgeType
    {
        Tree,
        Forward,
        Backward,
        Cross
    }

    public class Edge
    {
        public Node V1 { get; set; }
        public Node V2 { get; set; }
        public int Weight { get; set; } = 1;
        public DfsEdgeType Type { get; set; }
    }

    public class Node
    {
        public int Data { get; set; }
        public IList<Edge> OutEdges { get; set; }

        internal bool IsVisited { get; set; }
        internal Node Parent { get; set; }
        internal int StartTime {get; set;}
        internal int EndTime { get; set; }
    }

    public class Dfs
    {
        public bool HasCyles(Node node)
        {
            Traverse(node);
            return IsCyclic;
        }
        private static int Counter = 0;
        private static bool IsCyclic = false;
        public void Traverse(Node current)
        {
            current.StartTime = ++Counter;
            foreach(var edge in current.OutEdges)
            {
                if(edge.V2.IsVisited)
                {
                    IsCyclic = true;

                    ////optional
                    //edge.Type = FindDfsEdgeType(edge);

                    continue;
                }

                ////optional
                //edge.Type = DfsEdgeType.Tree;

                edge.V2.Parent = current;
                Traverse(edge.V2);
            }

            current.EndTime = ++Counter;
        }

        public DfsEdgeType FindDfsEdgeType(Edge edge)
        {
            var from = edge.V1;
            var to = edge.V2;

            IList<Node> fromParents = new List<Node>();
            IList<Node> toParents = new List<Node>();

            var temp = from;
            while(temp.Parent != null)
            {
                fromParents.Add(temp.Parent);
                temp = temp.Parent;
            }

            temp = to;
            while (temp.Parent != null)
            {
                toParents.Add(temp.Parent);
                temp = temp.Parent;
            }

            if(fromParents.Contains(to))
            {
                return DfsEdgeType.Backward;
            }

            if (toParents.Contains(from))
            {
                return DfsEdgeType.Forward;
            }

            return DfsEdgeType.Cross;
        }
    }
}
