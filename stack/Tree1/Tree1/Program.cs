using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class Program
    {
        static void Main(string[] args)
        {
            WidthofTree w = new WidthofTree();
            Node tree = new Node(1);
            tree.left = new Node(2);
            tree.right = new Node(3);
            tree.left.left = new Node(4);
            tree.left.right = new Node(5);
            tree.right.right = new Node(8);
            tree.right.right.left = new Node(6);
            tree.right.right.right = new Node(7);
            BSTcs b = new BSTcs();
                b.BST(tree, 3);

            //PrintKDistance p = new PrintKDistance();
            //p.PrintNodeKdistance(tree, 2);

            //int[] arr1 = { 1, 2, 2, 1 };
            //int[] arr2 = { 2, 2 };
            //Intersection i = new Intersection();
            //i.FindIntersection(arr1, arr2);
        }
    }
}
