using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem8
    {
        public int vertices;
        public List<int>[] adj;
        public int[,] res;
        public Problem8(int v)
        {
            vertices = v;
            res = new int[v, v];
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
        public bool Iscyclic()
        {
            bool[] visited = new bool[vertices];
            for(int i=0; i<vertices;i++)
            {
                if(!visited[i])
                    if(IsCyclicUntil(i, visited,-1))
                    {
                        return true;
                    }
            }
            return false;

        }
        public bool IsCyclicUntil(int u, bool []visited, int parent)
        {
            visited[u] = true;
             foreach(int i in adj[u])
            {
                if (!visited[i])
                {
                    if (IsCyclicUntil(i, visited, u))
                        return true;
                }
                else if (i != parent)
                    return true;

            }
            return false;
        }

    }
}
