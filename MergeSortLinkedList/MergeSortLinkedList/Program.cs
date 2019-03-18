using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node a = new Node(9);
            //a.next = new Node(3);
            //a.next.next = new Node(4);
            //a.next.next.next = new Node(2);
            //a.next.next.next.next = new Node(5);
            //a.next.next.next.next.next = new Node(1);
            ////MergeSortLinkedList m = new MergeSortLinkedList();
            ////m.display(a);
            ////Node x = m.MergeSort(a);
            ////Console.WriteLine("sorted");
            ////m.display(x);
            ////Console.ReadKey();
            //Node n = new Node(1);
            //n.next = new Node(2);
            //n.next.next = new Node(2);
            //n.next.next.next = new Node(3);
            //n.next.next.next.next = new Node(3);
            //n.next.next.next.next.next = new Node(2);

            DiameterofTree d = new DiameterofTree();
            Node node = new Node(1);
            node.left = new Node(2);
            node.right = new Node(3);
            node.left.left = new Node(4);
            node.left.right = new Node(5);
          
            int res = d.GetDiameterofTree(node);

        }
    }
}
