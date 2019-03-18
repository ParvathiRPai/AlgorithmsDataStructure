using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class Height
    {
        public int GetHeightofTree(Node root)
        {
            if(root ==null)
            {
                return 0;
            }
            int leftheight = GetHeightofTree(root.left);
            int rightHeight = GetHeightofTree(root.right);
            return 1 + Math.Max(leftheight, rightHeight);

        }
    }
}
