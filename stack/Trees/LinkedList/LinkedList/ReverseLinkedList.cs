using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int Val)
        {
            this.data = Val;
        }
    }
    class ReverseLinkedList
    {
        public void Reverse(Node start)
        {
            Node current = start;
            Node Next = current.next;
            Node prev = current;
            current = Next;
            while(current != null)
            {
                Next = current.next;
                current.next=prev;
                prev = current;
                current = Next;
            }
         ;
        }
        public void Print(Node start)
        {
            while(start != null)
            {
                Console.WriteLine(start.data);
            }
        }
    }
}
