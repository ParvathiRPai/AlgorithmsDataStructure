using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class SortKthElement
    {
        public Node SortKth( Node node, int k)
        {
            Node head = node;
            Node tail = node;
            while(node !=null)
            {
                Node next = node.next;
                if(node.data < k)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                node = next;
            }
            tail.next = null;
            return head;
        }
        public void Display(Node start)
        {
            while(start!=null)
            {
                Console.WriteLine(start.data);
                start = start.next;
            }

        }
    }
}
