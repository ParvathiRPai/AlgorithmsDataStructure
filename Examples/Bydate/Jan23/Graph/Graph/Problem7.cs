using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem7
    {
        public int vertices;
        public List<int>[] adj;
        public int[,] res;
        public Problem7(int v)
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
        public void BFS()
        {
            bool[] visited = new bool[vertices];
            for(int i=0; i<vertices;i++)
            {
                if(!visited[i])
                {
                    BFS(i, visited);
                }
            }

        }
        public void BFS(int s , bool []visited)
        {
            var q = new Queue<int>();
            visited[s] = true;
            q.Enqueue(s);
            while(q.Count !=0)
            {
                s = q.Dequeue();
                Console.WriteLine(s);
                foreach(int i in adj[s])
                {
                    if (!visited[i])
                        q.Enqueue(i);
                }
            }
        }
    }
}
