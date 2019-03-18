using System;
using System.Collections.Generic;
using System.Text;

namespace MST1
{
    class vertex
    {
        public int data;
        public vertex leader;
        public IList<vertex> adj;
       public vertex()
        {
            leader = this;
        }
    }
}
