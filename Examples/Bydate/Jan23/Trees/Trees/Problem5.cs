using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Problem5
    {
        public int vertices;
        public List<int>[] adj;
        public Problem5(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for(int i=0;i<v;i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int u, int w)
        {
            adj[u].Add(w);
        }
        public void TopologicalSort()
        {
            var set = new HashSet<int>();
            var stack = new Stack<int>();
            for(int i=0; i<vertices;i++)
            {
                if(!set.Contains(i))
                {
                    
                    Sort(i, set, stack);
                }
            }
            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        public void Sort(int i , HashSet<int>set, Stack<int> s)
        {
            set.Add(i);
            foreach(int node in adj[i])
            {
                if (!set.Contains(node))
                {
                    Sort(node, set, s);
                }
                else
                {
                    s.Push(node);
                }
            }
           
        }
    }
}
