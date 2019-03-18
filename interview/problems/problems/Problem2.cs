using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class Sum
    {
        public int sum = 0;
    }
    class Problem2
    {
        public void ModifyBST(Node node, Sum s)
        {
            if (node == null)
            {
                return;
            }
            ModifyBST(node.right, s);
            s.sum = s.sum + node.data;
            node.data = s.sum;
            ModifyBST(node.left, s);

        }
        public void Inorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Inorder(node.left);
            Console.WriteLine(node.data);
            Inorder(node.right);



        }
    }

}
