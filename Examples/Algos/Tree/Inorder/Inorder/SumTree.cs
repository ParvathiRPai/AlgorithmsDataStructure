using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class SumTree
    {
        static Node newroot;
        public int Sum( Node node)
        {
            if (node == null)
            {
                return 0;
            }
            int left = Sum(node.left);
            int right = Sum(node.right);
            int returndata = node.data + left + right;
            node.data = left + right;
            newroot = node;
            return returndata;
        }

        public void Display(Node node)
        {
           if(node != null)
            {
                Display(node.left);
                Console.WriteLine(node.data + " ");
                Display(node.right);
            }
        }
    }
}
