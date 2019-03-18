using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class NodeLL
    {
        public int data;
        public NodeLL next;
        public NodeLL(int data)
        {
            this.data = data;
        }
    }
    class LinkedList
    {
        public int GetLength(Node start)
        {
            int count = 0; 
            while(start != null)
            {
                count++;
                start = start.next;
            }
            return count; 
        }
        public Node GetMiddle(Node start, int count)
        {
            int mid = count / 2;
            int i = 0;
            while(i<=mid)
            {
                start = start.next;
            }
            return start;
        }
        public Node ReverseFromMiddle(Node middle)
        {
            Node current = middle;
            Node prev = current;
            Node next = current.next;
            current = next;
            while(current!= null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            middle.next = null;
            middle = prev;
            return middle;
        }
     
    }
    
    
}
