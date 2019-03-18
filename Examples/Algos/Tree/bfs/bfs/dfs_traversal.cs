using System;
using System.Collections.Generic;
using System.Text;

namespace bfs
{
    class dfs_traversal
    {
        public void Dfs(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.data + " ");
            Dfs(node.left);
            Dfs(node.right);
        }
    }
}
