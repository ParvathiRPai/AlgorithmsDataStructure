using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MS7
    {
        public bool result;
        public bool IsSubtree(Node root1, Node root2)
        {
             Traverse(root1, root2);
            return result;
        }
        public void Traverse(Node p, Node q)
        {
            if (result == true) return;
            if (p == null || q == null)
                return;
            if(p.data==q.data)
            {
                var res = SubTree(p, q);
                if(res==true)
                {
                    result = true;
                    return;
                }
            }
            Traverse(p.left, q);
            Traverse(p.right, q);
        }
        public bool SubTree(Node p, Node q)
        {
            if (q == null && q == null)
                return true;
            if (q == null || q == null)
                return false;
            if (p.data == q.data)
                return SubTree(p.left, q.left) && SubTree(p.right, q.right);
            return false;
        }
    }
}
