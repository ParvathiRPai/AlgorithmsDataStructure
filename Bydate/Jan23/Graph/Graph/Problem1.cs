using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        public int vertices;
        public List<int>[] adj;
        public Graph(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for(int i=0; i<v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void addEdge(int u , int w)
        {
            adj[u].Add(w);
        }
        public void DFS(int s, bool[] visited)
        {
            var stack = new Stack<int>();
            stack.Push(s);
            visited[s] = true;
            while (stack.Count != 0)
            {
                 s = stack.Pop();
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
        public int FindMother()
        {
            bool[] visited = new bool[vertices];
            int v = 0; 
            for(int i=0; i<vertices;i++)
            {
                if(visited[i]==false)
                {
                    DFS(i, visited);
                    v = i;
                }
            }
            for(int i=0; i<vertices;i++)
            {
                visited[i] = false;
            }
            DFS(v, visited);
            for(int i=0; i<vertices;i++)
            {
                if (visited[i] == false)
                    return -1;
                   
            }
            return v;
        }

    }
   
}
