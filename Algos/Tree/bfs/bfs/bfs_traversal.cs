using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace bfs
{
    class bfs_traversal
    {
        public void Bfs(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.WriteLine(node.data + "");
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
              

            }
        }

    }
}
