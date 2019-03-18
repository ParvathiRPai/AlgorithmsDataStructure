using System;
using System.Collections.Generic;
using System.Text;

namespace bfs_and_dfs
{
    public class Node
    {
    
        public Node left;
        public Node Right;
        public string data;
        internal Node right;

        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.Right = right;
        }
        public Node(string data)
        {
            this.data = data;
            this.left = null;
            this.Right = null;
        }
    }
}

