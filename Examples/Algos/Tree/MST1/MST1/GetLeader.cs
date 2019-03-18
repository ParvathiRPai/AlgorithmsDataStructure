using System;
using System.Collections.Generic;
using System.Text;

namespace MST1
{
    class GetLeader:Igraph
    {
        public vertex GetleaderNode(vertex v1)
        {
            vertex temp = v1;
            while(temp.leader!=temp)
            {
                temp = temp.leader;
            }
            return temp;
        }
    }
}
