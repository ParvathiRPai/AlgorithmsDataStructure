using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n = new Node(3);
            //n.left = new Node(9);
            //n.right = new Node(20);
            //n.right.left = new Node(15);
            //n.right.right = new Node(7);
            //Problem1 p = new Problem1();
            //p.ZigZag(n);

            //int[] arr = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            //int target = 3;
            //Problem2 p = new Problem2();
            //int index=p.Sorted(arr, target);

            Graph g = new Graph(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            g.PrintAdjacecnyMatrix();
            g.DFS(2);
            g.PrintAdjacecnyMatrix();
        }
    }
}
