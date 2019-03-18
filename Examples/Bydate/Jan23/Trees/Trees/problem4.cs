using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class problem4
    {
        public bool IsSubTree(Node s, Node t)
        {
            if (s == null)
                return false;
            if(s.data ==t.data)
            {
                bool issubtree = CheckSubTree(s, t);
                if (issubtree)
                    return true;
            }
            return IsSubTree(s.left, t) || IsSubTree(s.right, t);
        }
        public bool CheckSubTree(Node s, Node t)
        {
            if (s == null || t == null)
                return false;
            if (s.data != t.data)
                return false;
            return CheckSubTree(s.left, t.left) && CheckSubTree(s.right, t.right);
        }
    }
}
