using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem99
    {
        Node bigger = null;
        Node smaller = null;
        Node prev = null;
        public void RecoverBST(Node root)
        {
            BST(root);
            if(bigger !=null && smaller !=null)
            {
                int temp = bigger.val;
                bigger.val = smaller.val;
                smaller.val = bigger.val;
            }
        }

        public void BST(Node root)
        {
            if (root == null)
                return;
            BST(root.left);
            if(prev !=null && prev.val > root.val)
            {
                if (bigger == null)
                {
                    bigger = prev;
                    smaller = root;
                }
                else
                    smaller = root;
            }
            prev = root;
            BST(root.right);
        }
        public void Print(Node root)
        {
            if (root == null)
                return;
            Print(root.left);
            Console.WriteLine(root.val);
            Print(root.right);
        }
    }
}
