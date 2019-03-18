using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
   class Problem1
    {
        HashSet<int> seen = new HashSet<int>();
        int max_edge = 20;
        public int [] RedundantEdges(int [][]edges)
        {
            List<int>[]graph = new List<int>[max_edge];
            for(int i=0; i<max_edge;i++)
            {
                graph[i] = new List<int>();
            }
            foreach (int[] edge in edges)
            {
                seen.Clear();
                if (graph[edge[0]] != null && graph[edge[1]] != null && DFS(graph, edge[0], edge[1]) == true)
                {
                    return edge;
                }
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            throw new Exception("No such edge present");
        }
        public bool DFS(List<int> []graph, int source, int target)
        {
            if(! seen.Contains(source))
            {
                seen.Add(source);
                if (source == target)
                    return true;
                foreach(int i in graph[source])
                {
                    DFS(graph, i, target);
                    return true;
                }
            }
            return false;
        }

    }
}
