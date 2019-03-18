using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ReverseKElements
    {
        public void ReverseK(Node start, int k)
        {
            Node current = start;
            Node next = null;
            Node prev = null;
            int count = 0;
            while(current != null && count <k)
            {
                next = current.next;
                prev = current;
                current = next;
                count++;
            }
            if(start !=null)
            {
                start.next = current;
            }
            count = 0; 
            while(count<k-1 && current != null)
            {
                current = current.next;
                count++;
            }
            if(current != null)
            {
                ReverseK(current.next, k);
            }
        }
    }
}
