using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLinkedList
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data, Node left, Node right)
        {
            this.left = left;
            this.right = right;
            this.data = data;
        }
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
