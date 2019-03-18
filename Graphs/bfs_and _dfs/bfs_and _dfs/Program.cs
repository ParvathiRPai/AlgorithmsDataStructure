using bfs_and_dfs;
using System;

namespace bfs_and__dfs
{
    public partial class Program
    {
        static Node Sample_tree()
        {
            Node root = new Node("A", new Node("B", new Node("c"), new Node("D")), new Node("E", new Node("F"), new Node("G", new Node("h"), null)));
            return root;
        }
        static void Main(string[] args)
        {
            Node tree = Sample_tree();



            dfs.DFS(tree);
            Console.Write(tree);
            Console.ReadKey();
        }
    }
}
