using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
    }
    class LinkedList
    {
        private Node StartNode;
        public LinkedList()
        {
            StartNode = null;
        }
        public void Add(int data)
        {
            int count = 0;
            if(data==null)
            {
                throw new ArgumentException("invalid");
            }
            Node node = new Node();
            node.data = data;
            if(StartNode==null)
            {
                StartNode = node;
            }
            else
            {
                var current = StartNode;
                while(current.Next!=null)
                {
                    current = current.Next;
                }
                current.Next = node;    
            }
            Print(node);
            Console.WriteLine(count++);
            

        }
        public void Print(Node Start)
        { 
       
                Console.WriteLine(Start.data); 
        }
       
    }
}
