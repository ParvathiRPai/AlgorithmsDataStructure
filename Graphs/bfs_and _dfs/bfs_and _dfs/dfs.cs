using bfs_and_dfs;
using System;
using System.Collections.Generic;
using System.Text;

namespace bfs_and_dfs
{
public class dfs
{
    public static void DFS(Node node)
    {
            if (node == null)
                return;
            DFS(node.left);
            DFS(node.right);

    }

 }
}
