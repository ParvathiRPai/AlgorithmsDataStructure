using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS8
    {
        public NodeLL ReverseKPairs(NodeLL head, int k)
        {
            int count = 0;
            NodeLL current = head;
            NodeLL next = null;
            NodeLL prev = null;
            while(current != null && count < k)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }
            if(next != null)
            {
                head.next=ReverseKPairs(next, k);
            }
            return prev;
        }

    }
}
