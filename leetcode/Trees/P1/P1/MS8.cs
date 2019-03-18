using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MS8
    {
        public bool IsBST(Node root)
        {
            if (root == null)
                return true;
            if (root.left != null && root.left.data > root.data)
                return false;
            if (root.right != null && root.right.data < root.data)
                return false;
            bool l = IsBST(root.left);
            bool r = IsBST(root.right);
            return l && r;
        }
    }
}
