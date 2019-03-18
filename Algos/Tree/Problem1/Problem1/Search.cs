using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    class Search
    {
       
        public bool SearchRoute(Vertex beginVertex, Vertex endVertex, Graph g)
        {
            if (endVertex == beginVertex)
                return true;
            var isVisited = new Dictionary<Vertex, bool>();
            foreach (var vertex in g.Vertices)
            {
                isVisited[vertex] = false;
            }
            var currentVisitedVertices = new List<Vertex> { beginVertex };
            while (currentVisitedVertices.Count > 0)
            {
                var nextVisitedVertices = new List<Vertex>();
                foreach (var visitedVertex in currentVisitedVertices)
                {
                    if (isVisited[visitedVertex])
                    {
                        continue;
                    }
                    isVisited[visitedVertex] = true;

                    if (visitedVertex.Equals(endVertex))
                    {
                        return true;
                    }

                    nextVisitedVertices.AddRange(visitedVertex.neighbors);
                }

                currentVisitedVertices = nextVisitedVertices;
            }

            return false;
        }

    }
}
