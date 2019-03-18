using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MSP2
    {
        public bool FindSameTree(Node p, Node q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;

            return (p.data ^ q.data) == 0 && FindSameTree(p.left, q.left) && FindSameTree(q.right, p.right);
        }
    }
}
