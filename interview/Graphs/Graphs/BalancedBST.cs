using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class BalancedBST
    {
        public bool IsBalanced(Node root)
        {
            int height=0;
            return IsBalanced(root,  height);

        }
        public bool IsBalanced(Node root, int height)
        {
            if(root==null)
            {
                height = 0;
                return true;
            }
            int lefth=0;
            int righth=0;
            if(IsBalanced(root.left,lefth) && IsBalanced(root.right,righth) && Math.Abs(lefth-righth) <=1)
            {
                height = Math.Max(lefth, righth) + 1;
                return true;
            }
            return false;
        }
        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            int left = 0;
            int right = 0;
            left = MaxDepth(root.left);
            right = MaxDepth(root.right);
            return 1 + Math.Max(left, right);
        }
    }
}
