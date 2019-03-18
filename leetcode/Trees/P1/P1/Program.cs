using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n = new Node(-10);
            //n.left = new Node(9);
            //n.right = new Node(20);
            //n.right.left = new Node(15);
            //n.right.right = new Node(7);

            //Node m = new Node(3);
            //m.left = new Node(9);
            //m.right = new Node(0);
            //m.right.left = new Node(15);
            //m.right.right = new Node(7);

            // MS5 p = new MS5();
            // string arr = "1, 2, 3, 0, 0, 4, 5 ";
            //Node res=p.LevelOrderTraversal(arr);

            //MS8 m = new MS8();
            //int[] pre = { 3, 9, 20, 15, 7 };
            //int[] inorder = { 9, 3, 15, 20, 7 };
            //Node root=m.CreateTree(pre, inorder);

            Node n = new Node(3);
            n.left = new Node(1);
            n.right = new Node(4);
            
            n.left.right = new Node(2);
            MS9 p = new MS9();
            int res = p.KthSmallest(n,1);

        }
    }
}
