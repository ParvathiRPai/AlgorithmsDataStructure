using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopDetection l = new LoopDetection();
            Node n = new Node('a');
            n.next = new Node('b');
            n.next.next = new Node('c');
            n.next.next.next = new Node('d');
            n.next.next.next.next = new Node('e');
            n.next.next.next.next = n.next.next;
            Node res = l.Loop(n);

        }
    }
}
