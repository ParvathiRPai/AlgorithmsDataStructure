using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tree t = new Tree();
            //Height h = new Height();
            //SumTree s = new SumTree();
            //MaxOfTree m = new MaxOfTree();
            //SumofLeafNodes s = new SumofLeafNodes();
            //InorderTree i = new InorderTree();
            //SizeOfTree s = new SizeOfTree();
            //BinarySearchTree b = new BinarySearchTree();
            //InsertElementinBST b = new InsertElementinBST();
            //LCA l = new LCA();
            LCAVector l = new LCAVector();
            Node node = new Node(5);
            node.left = new Node(-1);
            node.right = new Node(3);
            node.left.left = new Node(-2);
            node.left.right = new Node(4);
            node.right.left = new Node(-6);
            node.right.right = new Node(10);

            //int result = s.SumofLeftNodes(node);
            //Node result = b.BST(node, key);
            //Node result=b.Insert(node, 11);
            //Node result = l.CommonAn(node, node.right.left,node.right.right);

            bool result = l.FindPath(node, -6);
            Console.WriteLine(result);
            Console.ReadKey();

           

        }

    }
}
