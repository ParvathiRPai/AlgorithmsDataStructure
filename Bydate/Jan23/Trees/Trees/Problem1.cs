using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int x)
        {
            data = x;
        }
    }
    class Problem1
    {
        public int GetHeight(Node root)
        {
            if (root == null)
                return 0;
            int left = GetHeight(root.left);
            int right = GetHeight(root.right);
            return 1 + Math.Max(left, right);
        }
        public void Revese(Node root)
        {
            if (root == null)
                return ;
            Console.WriteLine(root.data);
            Node temp = root.left;
            root.left = root.right;
            root.right = temp;
            Revese(root.left);
            Revese(root.right);
        }
    }
}
