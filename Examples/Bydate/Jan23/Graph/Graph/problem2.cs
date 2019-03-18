using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class problem2
    {
        public int vertices;
        public List<int>[] adj;
        public int[,] res;
        public problem2(int v)
        {
            vertices = v;
            res = new int[v, v];
            adj = new List<int>[v];
            for(int i=0; i<v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void addEdge(int u, int w)
        {
            adj[u].Add(w);
        }
        public void FindPath()
        {
            for(int i=0; i<vertices;i++)
            {
                DFS(i, i);
            }
                    
        }
        public void DFS(int s, int v)
        {
            res[s, v] = 1;
            foreach(int i in adj[v])
            {
                if(res[s,i]==0)
                {
                    DFS(s, i);
                }
            }
        }
    }
}
