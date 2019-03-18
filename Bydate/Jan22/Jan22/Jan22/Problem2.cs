using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class Problem2
    {
        public Node Add(Node p, Node q)
        {
            Node res = new Node(0);
            Node l1 = p, l2 = q, current = res;
            int carry = 0;
            while(l1 != null && l2 != null)
            {
                int x = (l1 != null) ? l1.data : 0;
                int y = (l2 != null) ? l2.data : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                current.next = new Node(sum % 10);
                current = current.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if(carry > 0)
            {
                current.next = new Node(carry);
            }
            return res.next;
        }
    }
}
