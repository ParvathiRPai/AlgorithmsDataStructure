using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class BinarySearchTree
    {
        public Node BST(Node root, int key)
        {
            if(root==null)
            {
                return null;
            }

            if (root.data == key)
            {
                return root;
            }
            else if (root.data > key)
            {
                return BST(root.left, key);
            }
            else if (root.data < key)
            {
                return BST(root.right, key);
            }
            return null; 
            

        }
    }
}
