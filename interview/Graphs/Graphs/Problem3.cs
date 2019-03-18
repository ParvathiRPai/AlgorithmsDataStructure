using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem3
    {
        public Node Tree(int []preOrder, int []inOrder)
        {
            int pre = 0;
            int ino= 0;
            Node end = null;
            return TreeConstruct(preOrder, inOrder, pre, ino,end);
        }
        public Node TreeConstruct(int []preOrder, int []inOrder, int pre, int ino, Node end)
        {
            if(pre > preOrder.Length)
            {
                return null;
            }
            Node n = new Node(preOrder[pre]);
            if(inOrder[pre] != n.val)
            {
                n.left = TreeConstruct(preOrder, inOrder, pre, ino,n);
            }
            pre++;
            if(pre < inOrder.Length && inOrder[pre]!=n.val || end==null)
            {
                n.right= TreeConstruct(preOrder, inOrder, pre, ino,end);
            }
            return n;
        }
    }
}
