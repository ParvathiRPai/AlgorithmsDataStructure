using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class LCA
    {
        public Node CommonAn(Node root, Node p, Node q)
        {
            if( root == null)
            {
                return null;
            }
            if(p==root || q ==root)
            {
                return root;
            }
            Node leftNode = CommonAn(root.left, p, q);
            Node rightNode = CommonAn(root.right, p, q);
           if(leftNode !=null && rightNode !=null)
            {
                return root;
            }
            return leftNode != null ? leftNode : rightNode;
        }
    }
}
