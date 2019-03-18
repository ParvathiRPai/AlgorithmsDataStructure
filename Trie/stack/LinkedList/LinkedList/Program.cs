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
            //Merge merge = new Merge();
            //Node n = new Node(1);
            //n.next = new Node(2);
            //n.next.next = new Node(3);

            //Node m = new Node(4);
            //m.next = new Node(5);
            //m.next.next = new Node(6);
            //merge.MergeLinkedList(n, m);

            FindPrimeNumbers f = new FindPrimeNumbers();
            f.GetPrimeNumbers(10);

        }
    }
}

