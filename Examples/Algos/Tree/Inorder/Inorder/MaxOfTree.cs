using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class MaxOfTree
    {
        public int GetMaxElementInTree(Node node)
        {
            if(node == null)
            {
                return 0;
            }
            return Max(node.data, GetMaxElementInTree(node.left), GetMaxElementInTree(node.right));

        }
        public int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
    }
}
