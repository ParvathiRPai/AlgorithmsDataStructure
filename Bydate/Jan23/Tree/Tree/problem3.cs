using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Graph
    {
        public int vertices;
        List<int>[] adj;
        public Graph(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for(int i=0; i<v;i++)
            {
                adj[i] = new List<int>(); 
            }
        }
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        public void BFS(int s)
        {
            bool[] visted = new bool[vertices];
            visted[s] = true;
            var q = new Queue<int>();
            q.Enqueue(s);
            while(q.Count > 0)
            {
                s=q.Dequeue();
                Console.WriteLine(s);
                foreach(int next in adj[s])
                {
                    if(!visted[next])
                    {
                        visted[next] = true;
                        q.Enqueue(next);
                    }
                }
            }
        }
        public void DFS(int s)
        {
            bool[] visited = new bool[vertices];
            var st = new Stack<int>();
            st.Push(s);
            while(st.Count != 0)
            {
                s = st.Pop();
                Console.WriteLine(s);
                foreach( int i in adj[s])
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        st.Push(i);
                    }
                }
            }
        }
        public void PrintAdjacecnyMatrix()
        {
            for (int i = 0; i < vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }
        public 

    }
}
