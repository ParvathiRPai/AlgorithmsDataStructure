using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int x)
        {
            this.data = x;
        }
    }
    class S2
    {
        public int sum = 0;
        public Node GreaterTree(Node start)
        {
            if (start == null)
                return null;
            if(start != null)
            {
                GreaterTree(start.right);
                sum += start.data;
                start.data = sum;
                GreaterTree(start.left);
            }
            return start;
        }
    
    }
}
