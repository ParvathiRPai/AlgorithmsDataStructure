using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MSP3
    {
        public Node FlipTree(Node root)
        {
            if (root == null)
                return null;
            Node temp = root.left;
            root.left = root.right;
            root.right = temp;
            FlipTree(root.left);
            FlipTree(root.right);
            return root;
  
        }
    }
}
