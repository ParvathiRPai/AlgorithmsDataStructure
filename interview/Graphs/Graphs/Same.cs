using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Same
    {
        public bool SameTree(Node p, Node q)
        {
            if(p==null && q==null)
            {
                return true;
            }
            if(p==null || q == null || p.val !=q.val)
            {
                return false;
            }



            return SameTree(p.left, q.left) && SameTree(p.right, q.right);
                
            
        }
    }
}
