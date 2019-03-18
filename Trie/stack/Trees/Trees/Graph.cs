using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
   public class Graph
    {
        public int V, E;
        public Edge[] edge;
        public Graph(int v, int e)
        {
            this.V = v;
            this.E = e;
            edge = new Edge[E];
            for(int i=0; i<e;i++)
            {
                edge[i] = new Edge();
            }

        }
        public int Iscycle(Graph graph)
        {
            int[] parent = new int[graph.V];
            for(int i=0; i<graph.V;i++)
            {
                parent[i] = -1;
            }
            for (int i = 0; i < graph.E; i++)
            {
                int x = graph.Find(parent, graph.edge[i].src);
                int y = graph.Find(parent, graph.edge[i].dst);
                if (x == y)
                    return 1;
                graph.Union(parent, x, y);
            }
            return 0;

            
        }
        public void Union(int []parent, int x, int y)
        {
            int xset = Find(parent, x);
            int yset = Find(parent, y);
            parent[xset] = yset;
        }
        public int Find(int[]parent, int src)
        {
            if (parent[src] == -1)
                return src;
            return Find(parent, parent[src]);
        }
    }
    public class Edge
    {
        public int src, dst;
    }
 
}
