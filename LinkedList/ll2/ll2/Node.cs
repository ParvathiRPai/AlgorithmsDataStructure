using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class Node
    {
        public int data;
        public Node next; 
        public Node(int data)
        {
            this.data = data;
        }
    }
    class TNode
    {
        public int data;
        public TNode left, right;
        public TNode(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }
}
