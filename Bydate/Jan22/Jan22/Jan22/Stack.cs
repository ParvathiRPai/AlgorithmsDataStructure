using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Stack
    {
        private Node top;
        public void Push(int data)
        {
            Node t = new Node(data);
            t.next = top;
            top = t;
        }
        public int Pop()
        {
            int item = top.data;
            top = top.next;
            return item;
        }
    }
    class Queue
    {
        public Node first;
        public Node last; 
        public void Add(int data)
        {
            Node t = new Node(data);
            last = t;
            if(last!= null)
            {
                last.next = t;
            }
        }
    }
}
