using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class LinkedList
    {
        public Node RemoveNthLastNode(Node start, int k)
        {
            Node dummy = new Node(0);
            dummy.next = start;
            Node fast = dummy;
            Node slow = dummy;
            for(int i=0; i< k+1;i++)
            {
                fast = fast.next;
            }
            while(fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return dummy.next;
        }
        public Node MergeList(Node start1, Node start2)
        {
            Node result = null;
            if (start1 == null)
                return start2;
            if (start2 == null)
                return start1;
            if(start1.data >start2.data)
            {
                result = start2;
                result.next = MergeList(start1, start2.next);
            }
            else if(start2.data > start1.data)
            {
                result = start1;
                result.next = MergeList(start1.next, start2);
            }
            return result;
        }
        public Node MergeKList(Node []arr, int n)
        {
            while( n!= 0)
            {
                int i = 0, j=n;
                while(i<j)
                {
                    arr[i] = MergeList(arr[i], arr[j]);
                        i++;
                    j--;
                    if (i >= j)
                        n = j;
                }
            }
            return arr[0];
        }
        public void Print(Node start)
        {
            while(start != null)
            {
                Console.WriteLine(start.data);
                start = start.next;
            }
        }

        public Node ReverseKthElement(Node start, int k)
        {
            Node current = start;
            Node next = null;
            Node prev = null;
            int count = 0;
         while(current !=null && count <k)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }
         if(next !=null)
            {
                start.next = ReverseKthElement(next, k);
            }
            return prev;
        }

        public void RotateLinkedList(Node start, int k)
        {
            if (k == 0)
                return;
            Node current = start;
            int count = 1;
            while(count <k && current !=null)
            {
                current = current.next;
                count++;
            }
            if (current == null)
                return;
            Node kthNode = current;
            while(current.next != null)
            {
                current = current.next;
                current.next = start;
                start = kthNode.next;
                kthNode.next = null;
            }

        }

    }
}
