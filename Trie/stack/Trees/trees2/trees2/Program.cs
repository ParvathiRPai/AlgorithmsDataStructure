using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 5, 10, 15, 20 };
            //BST b = new BST();
            //Node res=b.CreateBST(arr, 0, arr.Length-1);
            Node n = new Node(2);
            n.left = new Node(3);
            n.right = new Node(4);
            n.left.left = new Node(5);
            n.left.right = new Node(6);
            BFS b = new BFS();
            b.DFS(n);

        }
    }
}
