using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node n = new Node(1);
            //n.next = new Node(2);
            //n.next.next = new Node(5);
            //n.next.next.next = new Node(8);
            //n.next.next.next.next = new Node(10);

            //KReverse k = new KReverse();
            //k.KReverseNodes(n, 2);
            StackDS d = new StackDS(4);
            d.Push(2);
            d.Push(3);
            d.Push(1);
            d.Push(5);
            d.Pop();


          
        }
    }
}
