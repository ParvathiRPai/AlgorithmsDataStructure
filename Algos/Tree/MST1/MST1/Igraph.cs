using System;
using System.Collections.Generic;
using System.Text;

namespace MST1
{
    class Igraph
    {
        public IList<vertex> vertices;
        public void Merge(vertex v1, vertex v2);
        public void MST();
        public void sortedges();
        private void getleader(vertex v1);
        private void getedges();

    }
}
