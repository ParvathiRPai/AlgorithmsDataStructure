using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem236
    {
        public Node LCA(Node root, Node p, Node q)
        {
            if(root == null)
            {
                return null;
            }
            if(root==p || root== q)
            {
                return root;
            }
            Node left = LCA(root.left, p, q);
            Node right = LCA(root.right, p, q);
            if(left == null && right == null)
            {
                return null;
            }
            if(left != null  && right != null)
            {
                return root;
            }
            return left != null ? left : right; 
        }
    }
}
