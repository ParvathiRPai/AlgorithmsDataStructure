using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem9
    {
        public int vertices;
        public List<int>[] adj;
        public int[,] res;
        public Problem9(int v)
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
        public bool IsCyclic()
        {
            bool[] isVisted = new bool[vertices];
            bool[] set = new bool[vertices];
            for (int i = 0; i < vertices; i++)
            {
                if(!isVisted[i])
                {
                    if (Cyclic(i, isVisted, set))
                        return true;
                }
            }

            return false;
        }
        public bool Cyclic(int i, bool []isVisited, bool []set)
        {
            if (set[i])
                return true;
            if (isVisited[i])
                return false;
            isVisited[i] = true;
            set[i] = true;
            foreach(int s in adj[i])
            {
                if (Cyclic(s, isVisited, set))
                    return true;
                set[i] = false;
            }
            return false;
        }
    }
}
