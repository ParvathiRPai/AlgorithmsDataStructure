using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class KReverse
    {
        public Node KReverseNodes(Node start, int k)
        {
            Node result = null;
            int count = 0;
            while(start!=null)
            {
                while(count<k)
                {
                    if(count !=k)
                    {
                        start = start.next;
                        count++;
                    }
                    else if(count==k)
                    {
                        result = Reverse(start);
                        start = start.next;
                        count = 0;
                    }
                }

            }
            return result; 

        }
        public Node Reverse(Node start)
        {
            Node current = start;
            Node next = current.next;
            Node prev = current;
            current = next;
            while(current !=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return current;

        }
    }
}
