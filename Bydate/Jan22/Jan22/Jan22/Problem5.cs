using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class NodeBB
    {
        public int data;
        public NodeBB left, right;
        public NodeBB(int x)
        {
            data = x;
        }
    }
    class Problem5
    {
        Stack<NodeBB> s = new Stack<NodeBB>();
        public void BSTIterator(NodeBB root)
        {
            while (root != null)
            {
                s.Push(root);
                root = root.left;
            }
            
        }
        public bool Hasnext()
        {
            return s.Count > 0;

        }
        public int Next()
        {
            var node = s.Pop();
            if(node.right != null)
            {
                var n = node.right;
                while(n!=null)
                {
                    s.Push(n);
                    n = n.left;
                }
            }
            return node.data;
        }
    }
}
