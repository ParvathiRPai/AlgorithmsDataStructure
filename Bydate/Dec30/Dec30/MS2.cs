using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class NodeLL
    {
        public int val;
        public NodeLL next;
        public NodeLL (int x)
        {
            this.val = x;
        }
    }
    class MS2
    {
        public NodeLL AddLL(NodeLL l1, NodeLL l2)
        {
            NodeLL l3 = new NodeLL(0);
            NodeLL current = l3;
            NodeLL p = l1;
            NodeLL q = l2;
            int carry = 0;
            while(p!=null && q!=null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
              
                current.next = new NodeLL(sum % 10);
                current = current.next;
                if (p != null)
                    p = p.next;
                if (q != null)
                    q = q.next;
            }
            if (carry > 0)
            {
                current.next = new NodeLL(carry);
            }
            return l3.next ;
        }
    }
}
