using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem3
    {
        public int vertices;
        public List<int>[] adj;
        public Problem3(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void addEdge(int u, int w)
        {
            adj[u].Add(w);
        }
        public int CountPaths(int start, int end)
        {
            int count = 0;
            bool[] isVisited = new bool[vertices];
            count = CountPathsUntil(start, end, isVisited, count);
            return count;
        }
        public int CountPathsUntil(int start, int end, bool []isVisited, int count)
        {
            isVisited[start] = true;
            if(start==end)
            {
                count++;
            }
            else
            {
                foreach(int i in adj[start])
                {
                    if(!isVisited[i])
                    {
                        count = CountPathsUntil(i, end, isVisited, count);
                    }
                }
            }
            isVisited[start] = false;
            return count;
        }
    }
}
