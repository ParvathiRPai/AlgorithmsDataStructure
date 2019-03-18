using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MS9
    {
        private int count;
        private int result;

        public int KthSmallest(Node root, int k)
        {
            count = k;

            InOrder(root);

            return result;
        }

        private void InOrder(Node root)
        {
            if (root == null) return;
            InOrder(root.left);
            count--;

            if (count == 0)
            {
                result = root.data;
                return;
            }
            InOrder(root.right);
        }
    }
}
