using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS7
    {
        public NodeLL SwapPairs(NodeLL head)
        {
            if (head == null || head.next == null) return head;
            NodeLL node = head;
            head = node.next; // remember head node;
            NodeLL prevNode = null;
            while (node != null)
            {
                NodeLL nextPair = null;
                if (node.next != null)
                {
                    nextPair = node.next.next; // remember next pair start
                    node = SwapPair(node); // swap current pair
                }
                if (prevNode != null) prevNode.next = node; // link prev pair to current
                prevNode = node.next; // remember current pair end
                node = nextPair;
            }
            return head;
        }
        NodeLL SwapPair(NodeLL node)
        {
            // assume node!=null and node.next!=null
            NodeLL nextNode = node.next; // node 2
            NodeLL nextNextNode = nextNode.next; // node 3
            node.next = nextNextNode; //link node 1 to 3
            nextNode.next = node; // link node 2 to 1
            return nextNode; // return node 2
        }
    }
}
