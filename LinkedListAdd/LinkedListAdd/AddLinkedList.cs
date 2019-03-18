using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAdd
{
    class AddLinkedList
    {
        public void Reverse(Node1 start1)
        {
            Node1 current = start1;
            Node1 next = current.next;
            Node1 prev = current;
            current = next;
            while(current!=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            start1.next = null;
            start1 = prev;
        }

        public void Display(Node1 start)
        {
            while(start!=null)
            {
                Console.WriteLine(start.data);
                start = start.next;
            }
        }

        public void Add(Node1 start1, Node2 start2)
        {
            Node1 p = start1;
            Node2 q = start2;
            Node2 dummy = new Node2(0);
            Node2
            int carry = 0;
            while(p!=null || q!=null)
            {
                int x = (p != null) ? p.data : 0;
                int y = (q != null) ? q.data : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                current.next = new Node2(sum % 10);
                current = current.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                current.next = new Node1(carry);
            }
            return 
        }

    }
}
