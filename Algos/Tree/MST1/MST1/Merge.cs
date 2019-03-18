using System;
using System.Collections.Generic;
using System.Text;

namespace MST1
{
    class Merge:Igraph
    {
        public vertex merge(vertex v1, vertex v2)
        {
            var g = new GetLeader();
            vertex L1 = g.GetleaderNode(v1);
            vertex L2 = g.GetleaderNode(v2);
            if(L1!=L2)
            {
                if(L1.data>L2.data)
                {
                    return L1.leader;
                }
                else
                {
                   return L2.leader;
                }
            }
            return L1.leader;


        }
    }
}
