using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int x)
        {
            data = x;
        }
    }
    class MSP1
    {
        public int FindMaxDepth(Node root)
        {
            if (root == null)
                return 0;
            int left = FindMaxDepth(root.left);
            int right = FindMaxDepth(root.right);
            return 1 + Math.Max(left, right);
        }
    }
}
