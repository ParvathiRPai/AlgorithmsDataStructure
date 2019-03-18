using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(1);
            n.next = new Node(2);
            n.next.next = new Node(3);
            n.next.next.next = new Node(4);


         ReverseLinkedList r = new ReverseLinkedList();
            r.Print(n);
            r.Reverse(n);
            r.Print(n);
            Console.ReadKey();
        }
    }
}
