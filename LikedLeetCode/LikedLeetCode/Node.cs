using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    class Tree
    {
        public int SumofPaths(Node root)
        {
            List<int> Sum = new List<int>();
            if(root==null)
            {
                return 0;
            }
           if(root.left==null || root.right==null)
            {
                return root.data;
            }
            int leftSum = SumofPaths(root.left);
            int rightSum = SumofPaths(root.right);
            int result = root.data + leftSum + rightSum;
            Sum.Add(result);
            int max = Sum.Max(t => t);
            return max;
           
        }
      
    }
}
