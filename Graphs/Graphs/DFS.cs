using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    //class Graph
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
    //    public void DFS(int start)
    //    {
    //        Boolean[] visited = new Boolean[vertices];
    //        Stack<int> s = new Stack<int>();
    //        visited[start] = true;
    //        s.Push(start);
    //        while(s.Count !=0)
    //        {
    //            start = s.Pop();
    //            Console.WriteLine(start);
    //            foreach(int i in adj[start])
    //            {
    //                if(!visited[i])
    //                {
    //                    visited[i] = true;
    //                    s.Push(i);
    //                }
    //            }
    //        }
    //    }
    //}
}
