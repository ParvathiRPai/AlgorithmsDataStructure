using System;

namespace bfs
{
    class Program
    {
        public static  Node Sampletree()
        {
            Node root = new Node("A", new Node("B", new Node("C"), new Node("D")), new Node("E", new Node("F"), new Node("G")));
            return root;
        }

        static void Main(string[] args)
        {
            //Node tree = Sampletree();
            //bfs_traversal bf = new bfs_traversal();
            //bf.Bfs(tree);
            //Console.WriteLine("BFS--->");
            //Console.ReadKey();

            Node tree = Sampletree();
            dfs_traversal bf = new dfs_traversal();
            bf.Dfs(tree);
            Console.WriteLine("DFS--->");
            Console.ReadKey();
        }
    }
}
