using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class SizeOfTree
    {
        public int Size(Node root)
        {
            if( root == null)
            {
                return 0;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int counter = 0;
            while(q.Count > 0)
            {
                root = q.Dequeue();   
                counter++;
                if (root.left != null)
                    q.Enqueue(root.left);
                if (root.right != null)
                    q.Enqueue(root.right);
            }
            return counter;
        }
    }
}
