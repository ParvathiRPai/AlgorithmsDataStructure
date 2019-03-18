using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(1);
            n.next = new Node(2);
            n.next.next = new Node(3);
            n.next.next.next = new Node(4);
            n.next.next.next.next = new Node(5);
            int k = 2;
            LinkedList l = new LinkedList();
              l.RotateLinkedList(n, k);
            


            //Node n = new Node(1);
            //n.next = new Node(4);
            //n.next.next = new Node(5);

            //Node n2 = new Node(1);
            //n2.next = new Node(3);
            //n2.next.next = new Node(4);

            //Node n3 = new Node(2);
            //n3.next = new Node(6);

            //LinkedList l = new LinkedList();
            //Node n1=l.MergeList(n, n2);
            //Node n4 = l.MergeList(n1, n3);
            //l.Print(n4);
        }
    }
}
