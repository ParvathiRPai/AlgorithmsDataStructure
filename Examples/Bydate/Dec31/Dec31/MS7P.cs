using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS7P
    {
        public NodeLL SwapPairs(NodeLL head)
        {
            NodeLL node = head;
            head = node.next;
            NodeLL prev = null;
            while(head != null)
            {
                NodeLL nextPair = null;
                if(node.next != null)
                {
                    nextPair = node.next.next;
                    node = Swap(head);

                }
                if (prev != null) prev.next = node;
                prev = node.next;
                node = nextPair;
            }
            return head;
        }
        public NodeLL Swap(NodeLL head)
        {
            NodeLL node = head;
            NodeLL nextNode = node.next;
            NodeLL nextnextNode = nextNode.next;
            node.next = nextnextNode;
            nextNode.next = node;
            return nextNode;
        }
    }
}
