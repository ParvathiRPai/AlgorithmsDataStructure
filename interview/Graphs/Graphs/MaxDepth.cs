using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem559
    {
        public int MaxDepth(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return 1 + Math.Max(left, right);

        }
    }
}
