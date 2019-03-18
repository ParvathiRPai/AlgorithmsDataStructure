using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Node n = new Node(10);
            // n.left = new Node(9);
            // n.right = new Node(20);
            // n.right.left = new Node(15);
            // n.right.right = new Node(7);
            // Problem2 p = new Problem2();
            //string res=p.Traversal(n);

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Problem10 p = new Problem10();
            p.Rotate(matrix);
            

        }
    }
}
