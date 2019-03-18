using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Merge
    {
        public void MergeLinkedList(Node List1,Node List2)
        {
            Node current1 = List1;
            Node current2 = List2;
            Node next1;
            Node next2;

            while (current1 != null && current2 != null)
            {
                next1 = current1.next;
                next2 = current2.next;

                current1.next = current2;
                current2.next = next1;
                current1 = next1;
                current2 = next2;

        
            }
        }
    }
}
