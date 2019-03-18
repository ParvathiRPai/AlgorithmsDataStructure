using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MSP4
    {
       public Node Invert(Node root)
        {
            if(root==null)
            {
                return null;
            }
            Node temp = root.left;
            root.left = root.right;
            root.right = temp;
            Invert(root.left);
            Invert(root.right);
            return root;
        }
        public int max;
        public int MaxSum(Node root)
        {
            max = 0;
            MaxDepth(root);
            return max;
        }
        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            int left = Math.Max(0, MaxDepth(root.left));
            int right = Math.Max(0, MaxDepth(root.right));
            max = Math.Max(max, left + right + root.data);
            return Math.Max(left, right) + root.data;
        }
    }
}
