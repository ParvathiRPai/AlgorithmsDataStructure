using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesringKthNodeofLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            Node insert = new Node(5);
            Node n = new Node(1);
            n.next = new Node(2);
            n.next.next = new Node(3);
            n.next.next.next = new Node(4);
            n.next.next.next.next = new Node(6);
            n.next.next.next.next.next = new Node(7);
            InsertNodeInLinkedList I = new InsertNodeInLinkedList();
            I.InsertNode(n, insert);
            l.Dispaly(n);
            //l.Dispaly(n);
            //l.Reverse(n);
            //while (n != null)
            //{
            //    l.Dispaly(n);
            //}
            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //Duplicate d = new Duplicate();
            //d.AddSum(arr);
            //Console.ReadKey();
            // int[] arr = { -1, 0, 3, 5, 9, 12 };
            // int target = 9;
            // FindTarget t = new FindTarget();
            //int res= t.GetIndexofTargetNumber(arr, target);
            // Console.WriteLine(res);
            // Console.ReadKey();
        }
    }
}
