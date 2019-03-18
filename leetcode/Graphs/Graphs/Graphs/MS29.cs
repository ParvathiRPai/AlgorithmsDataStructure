using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graph
    {

        public int vertices;
        public List<int>[] adj;
        public Graph(int v)
        {
            vertices = v;
            for(int i=0; i<v;i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void Add (int v, int w)
        {
            adj[v].Add(w);
        }
        public void Connected()
        {
            bool[] visited = new bool[vertices];
            for(int i=0; i< vertices;i++)
            {
                if(!visited[i])
                {
                    DFS(i, visited);
                }
            }
        }
        public void DFS(int v, bool []visited)
        {
            visited[v] = true;
            Console.WriteLine(v);
            foreach(int i in adj[v])
            {
                if (!visited[i])
                    DFS(i, visited);
            }
        }

       
    }
}
