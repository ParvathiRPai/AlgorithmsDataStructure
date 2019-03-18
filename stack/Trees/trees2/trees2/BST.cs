using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees2
{
    class BST
    {
        public Node CreateBST(int[] arr, int start, int end)
        {
            if (end < start)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node n = new Node(arr[mid]);
            n.left = CreateBST(arr, start, mid - 1);
            n.right = CreateBST(arr, mid + 1, end);
            return n;

        }

    }
}
