using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1 p = new Problem1();
            //int[ ][ ]edges = new int[][]{ 
            //    new int[]{ 1, 2 }, 
            //    new int[]{ 1, 3 }, 
            //    new int[]{ 2, 3 } };

            //int []res=p.RedundantEdges(edges);

            //Node n = new Node(1);
            //n.left = new Node(2);
            //n.right = new Node(3);
            //n.left.left = new Node(6);
            //n.left.right = new Node(2);
            //n.right.left = new Node(0);
            //n.right.right = new Node(8);
            //n.left.right.left = new Node(7);
            //n.left.right.right = new Node(4);
            // Problem2 p = new Problem2();
            // char[][] edges = new char[][]{
            //     new char[]{ '1', '1', '0', '0', '0'},
            //     new char[]{ '0', '1', '0', '0', '1'},
            //     new char[]{'1', '0', '0', '1', '1' },
            // new char[]{'0', '0', '0', '0', '0' },
            // new char[]{'1', '0', '1', '0', '1' } };
            //int res=p.numIslands(edges);

            //int[] arr = { 4, 10, 3, 5, 1 };
            //HeapSort h = new HeapSort();
            //h.Sort(arr);

            //Problem257 p = new Problem257();
            //int[] arr = { 1, 2, 3, 0, 5, 0, 4 };
            //int []res=p.PrintLeft(arr, arr.Length);

            //Node n = new Node(1);
            //n.left = new Node(2);
            //n.right = new Node(3);
            //n.right.right = new Node(5);
            //p.PrintPaths(n);

            //List<int> list = new List<int> { 1, 3 };
            //List<List<int>> l = new List<List<int>>{new List<int>{1,3},
            //new List<int>
            //{
            //    3,0,1
            //},
            //new List<int>
            //{
            //    2
            //},
            //new List<int>
            //{
            //    0
            //}
            //};
            //RoomKey r = new RoomKey();
            //r.CanVisitAllRooms(l);

            // Node n = new Node(1);
            // n.left = new Node(2);
            // n.right = new Node(3);
            // Node m = new Node(1);
            // m.left = new Node(1);
            // m.right = new Node(3);
            // Same p = new Same();
            //bool res= p.SameTree(n, m);

            //int[] preOrder = { 3, 9, 20, 15, 7 };
            //int[] inOrder = { 9, 3, 15, 20, 7 };
            //Problem3 p = new Problem3();
            //Node n =p.BuildTree(preOrder, inOrder);
            Node n = new Node(5);
            n.left = new Node(4);
            n.right = new Node(8);
            n.left.left = new Node(11);
            n.left.left.left = new Node(7);
            n.left.left.right = new Node(2);
            
            n.right.left = new Node(13);
            n.right.right = new Node(4);
            n.right.right.right = new Node(1);
            PathPresent2 b = new PathPresent2();
           List<List<int>> r= b.PathPresent(n, 22);

        }
    }
}
