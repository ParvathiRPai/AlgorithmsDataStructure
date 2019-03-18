using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class SumofLeafNodes
    {
        public bool IsLeaf(Node root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }
        public int SumofLeftNodes(Node node)
        {
            if( node==null)
            {
                return 0;
            }
            int sum = 0;
            if(IsLeaf(node.left)==true)
            {
                sum += node.left.data;
            }
            else
            {
                 sum+=SumofLeftNodes(node.left);
                 sum+=SumofLeftNodes(node.right);
            }
            return sum;
        }
    }
}
