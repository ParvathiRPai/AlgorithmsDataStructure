using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public int vertex;
        public List<int>[] adj;
        public Graph(int v)
        {
            vertex = v;
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
        public bool IsCyclic()
        {
            Boolean[] visited = new Boolean[vertex];
            Boolean[] instack = new Boolean[vertex];

            for(int i=0; i<vertex;i++)
            {
                if (isCyclicUntil(i, visited, instack))
                {
                    return true;
                }
            }
            return false;
        }
        public bool isCyclicUntil(int i, Boolean []isVisted, Boolean []instack)
        {
            if(instack[i]==true)
            {
                return false;
            }
            if(isVisted[i]==true)
            {
                return false;
            }
            isVisted[i] = true;
            instack[i] = true;
           
            foreach(int next in adj[i])
            {
                if(isCyclicUntil(next,isVisted,instack))
                {
                    return true;
                }
                else
                {
                    instack[i] = false;
                }
            }
            return false;
        }
    }
   
}
