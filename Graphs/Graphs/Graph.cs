using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    //public class Graph
    //{
    //    public int vertices;
    //    public List<int>[] adj;
    //    public Graph(int v)
    //    {
    //        vertices = v;
    //        adj = new List<int>[v];
    //        for(int i=0; i<v;i++)
    //        {
    //            adj[i] = new List<int>();
    //        }
    //    }
    //    public void AddEdge(int v, int w)
    //    {
    //        adj[v].Add(w);
    //    }
    //    public void BFS(int start)
    //    {
    //        Boolean[] visited = new Boolean[vertices];
    //        Queue<int> q = new Queue<int>();
    //        visited[start] = true;
    //        q.Enqueue(start);
    //        while(q.Count!=0)
    //        {
    //            start = q.Dequeue();
    //            Console.WriteLine(start);
    //            foreach(int next in adj[start])
    //            {
    //                if(!visited[next])
    //                {
    //                    visited[next] = true;
    //                    q.Enqueue(next);
    //                }
    //            }
                
                
    //        }
    //    }
    //}
}
