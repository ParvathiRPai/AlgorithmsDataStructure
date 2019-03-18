using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Node1 n1 = new Node1(7);
            n1.next = new Node1(1);
            n1.next.next = new Node1(6);
            AddLinkedList a = new AddLinkedList();
            
            a.Reverse(n1);
            a.Display(n1);
        }
    }
}
