using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class InsertElementinBST
    {
        public Node Insert(Node root , int element)
        {
            Node node = new Node(element);
           if(root == null)
            {
                return null;
            }

            Node current = root;
            Node parent = null;
           while(current != null)
            {
                parent = current;
                if(root.data < element)
                {
                    current = current.right;
                }
                else
                {
                    current = current.left;
                    
                }
            }
           if(parent.data <= element)
            {
                parent.right = node;
            }
            else
            {
                parent.left = node;
            }
            return root;
        }
    }
}
