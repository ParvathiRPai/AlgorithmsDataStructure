using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            
        }
        public Node()
        {
        }
    }
    class SortLinkedList
    {
        public Node Sort(Node start)
        {
            if(start == null || start.next== null)
            {
                return start;
            }

            Node Zero = new Node();
            Node Ones = new Node();
            Node Twos = new Node();

            Node zero = Zero;
            Node one = Ones;
            Node two = Twos;

            Node current = start;
            while(current != null)
            {
                if(current.data==0)
                {
                    zero.next = current;
                    zero = zero.next;
                }
                else if(current.data==1)
                {
                    one.next = current;
                    one = one.next;
                }
                else
                {
                    two.next = current;
                    two = two.next;
                }
                current = current.next;
            }
            zero.next = (Ones.next != null) ? (Ones.next) : (Twos.next);
            Ones.next = Twos.next;
            Twos.next = null;
            return Zero;
        }
    }
}
