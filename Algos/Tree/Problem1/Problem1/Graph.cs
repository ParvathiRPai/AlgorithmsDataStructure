using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    class Graph
    {
      public bool BFS(Vertex startv, Vertex endv, HashSet<Vertex> vertices)
        {
            if(vertices.Contains(startv))
            {
                return false;    
            }
            else
            {
                vertices.Add(startv);
            }
            if (startv == endv)
                return true;
            foreach(var v in startv.outedges)
            {
                var found = BFS(v, endv,vertices);
                    if(found==true)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
