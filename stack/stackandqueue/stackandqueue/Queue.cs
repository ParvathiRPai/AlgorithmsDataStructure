using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
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
    class Queue
    {
        private Node first;
        private Node last;

        public void Add(int data)
        {
            Node t = new Node(data);
            if(first==null)
            {
                first = last;
            }
            if(last !=null)
            {
                last.next = t;
            }
            last = t;
        }
        public int Remove()
        {
            if(first==null)
            {
                throw new Exception();
            }
            int data = first.data;
            first = first.next;
            return data;
        }

    }
}
