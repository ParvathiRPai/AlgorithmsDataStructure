using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Graphs
{
    public class BasicVertex
    {
        //here protected set means your descendants can set, including Mst1 and Bellman-Ford
        public int Data { get;set; }
    }
}
