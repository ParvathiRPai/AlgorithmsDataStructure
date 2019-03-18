using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem5
    {
        public int vertices;
        public List<int>[] adj;
        public Problem5(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for(int i=0; i<v;i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void addEdge(int u , int w)
        {
            adj[u].Add(w);
        }
        public void PrintPaths(int s, int d)
        {
            bool []visited = new bool[vertices];
            int[] path = new int[vertices];
            int pathindex = 0;
            DFS(s, d, visited, path, pathindex);
        }
        public void DFS(int s, int d, bool []visited, int []path, int pathindex)
        {
            visited[s] = true;
            
            
            path[pathindex] = s;
            pathindex++;
            if(s==d)
            {
                for(int i=0; i<pathindex;i++)
                {
                    Console.WriteLine(path[i]);
                }
            }
            else
            {
               
                    foreach (int i in adj[s])
                    {
                        if (!visited[i])
                        {
                            DFS(i, d, visited, path, pathindex);
                        }
                    }
                
            }
            pathindex--;
            visited[s] = false;
        }
    }
}
