using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class Problem2
    {
        public Node LargestBST(Node start)
        {
            return BST(start);
        }
        public Node BST(Node start)
        {
            return start;
            
        }
        public Node Min(Node start)
        {
            if (start == null)
                return start;
            while (start.left != null)
            {
                start = start.left;
            }
            return start;
        }

        public bool isBST(Node root)
        {
           
            if(root==null || root.left == null || root.right ==null)
            {
                return true;
            }
            if(root.val  < root.left.val )
            {
                return false;
            }
            if(root.val > root.right.val)
            {
                return false;
            }
             return isBST(root.left) && isBST(root.right);           
        }

    }
}
