using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Graph
    {
        public int vertices;
        public List<int>[] adj;
        public Graph(int v)
        {
            vertices = v;
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void Add(int u, int w)
        {
            adj[u].Add(w);
        }

        public void Sort(int s)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> set = new HashSet<int>();
            foreach (int next in adj[s])
            {
                if (set.Contains(next))
                {
                    continue;
                }
                TopSort(next, stack, set);
            }
        }
        public void TopSort(int vertex, Stack<int> s, HashSet<int> set)
        {
            set.Add(vertex);
            foreach (int i in adj[vertex])
            {
                if (set.Contains(i))
                {
                    continue;
                }
                TopSort(i, s, set);
            }
           
        }

    }
}
