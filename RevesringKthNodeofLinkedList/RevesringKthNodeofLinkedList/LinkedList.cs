using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesringKthNodeofLinkedList
{
    class LinkedList
    {
        public void Reverse(Node start)
        {
            Node current = start;
             if (current == null)
            {
                return;
            }
            Node next = current.next;
            Node prev = current;
            current = next; 
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            start.next = null;
            start = prev;

        }

        public void Dispaly(Node Start)
        {
            Node current = Start;
            while(current !=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
