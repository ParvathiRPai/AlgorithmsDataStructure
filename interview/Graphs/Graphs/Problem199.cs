using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Node
    {
        public Node left, right;
        public int val;
        public Node(int val)
        {
            this.val = val;
        }
    }

    class Problem199
    {
        public int[] PrintLeft(int[] arr, int n)
        {
            int i = 0;
            int[] res = new int[n];
            int index = 0;
            if (i == 0)
            {
                res[index] = arr[i];
                index++;
            }
            int j = 0;
            while (i <= n && j <= n)
            {
                j = 2 * i + 2;
                res[index] = arr[j];
                index++;
                i = i + 1;

            }
            return res;
        }
        public List<int> PrintLeftDFS(Node root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                result.Add(q.Peek().val);

                int curCount = q.Count();
                while (curCount > 0)
                {
                    var curNode = q.Dequeue();
                    if (curNode.right != null) q.Enqueue(curNode.right);
                    if (curNode.left != null) q.Enqueue(curNode.left);
                    curCount--;
                }
            }
            return result;
        }
    }
}
