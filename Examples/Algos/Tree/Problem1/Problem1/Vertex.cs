using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Vertex
    {
        public int data;
        public IList<Vertex> outedges = new List<Vertex>();
        public Vertex(int data)
        {
            this.data = data;
        }

    }
}
  
