using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class DiameterofTree
    {
        public int GetDiameterofTree(Node root)
        {
            int length = 0;
            if (root == null)
            {
                return length;
            }
            int leftDepth = GetHeightofTree(root.left);
            int rightDepth = GetHeightofTree(root.right);

            int leftdiameter = GetDiameterofTree(root.left);
            int rightdiameter = GetDiameterofTree(root.right);
            return Math.Max(leftDepth + rightDepth + 1,
                        Math.Max(leftdiameter, rightdiameter));

        }
        public int GetHeightofTree(Node start)
        {
            if (start == null)
            {
                return 0;
            }
            return Math.Max(GetHeightofTree(start.left), GetHeightofTree(start.right)) + 1;
        }
    }
}
