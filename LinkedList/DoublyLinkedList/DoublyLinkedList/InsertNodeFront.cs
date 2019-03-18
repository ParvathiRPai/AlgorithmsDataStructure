using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Solution
    {
        public void RemoveNthFromEnd(Node head, int n)
        {
            Node slow = head;
            Node fast = head;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }
            while (fast.next != null && fast.next !=null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = slow.next;
            slow.next = slow.next.next;

        }
        public void Print(Node start)
        {
            while(start !=null)
            {
                Console.WriteLine(start.data);
                start = start.next;
            }
        }
    }
}
