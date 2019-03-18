using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    public class NodeLL
    {
        public int data;
        public NodeLL next;
        public NodeLL(int data)
        {
            this.data = data;
        }
    }
    class MS5
    {
        public NodeLL Merge(NodeLL l1, NodeLL l2)
        {
            NodeLL ptr = new NodeLL(0);
            NodeLL head = ptr;
            while(l1 != null && l2 != null)
            {
                if(l1.data < l2.data)
                {
                    ptr.next = new NodeLL(l1.data);
                    l1 = l1.next;
                }
                else
                {
                    ptr.next = new NodeLL(l2.data);
                    l2 = l2.next;
                }
                ptr = ptr.next;
            }
            ptr.next = l1 != null ? l1 : l2;
            return head.next;
        }

    }
}

