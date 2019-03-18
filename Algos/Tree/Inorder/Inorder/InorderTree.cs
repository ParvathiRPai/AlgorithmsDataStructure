using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class InorderTree
    {
        public void InorderTraversal(Node root)
        {
            if(root == null)
            {
                return;
            }
            if (root != null)
            {
                InorderTraversal(root.left);
                Console.WriteLine(root.data + " ");
                InorderTraversal(root.right);
            }
          
           
        }
        public void PreOrderTraversal(Node root)
        {
            if(root == null)
            {
                return; 
            }
            Console.WriteLine(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }
        public void PostOrderTraversal(Node root)
        {
            if(root == null)
            {
                return;
            }
            PostOrderTraversal(root.right);
            PostOrderTraversal(root.left);
            
            Console.WriteLine(root.data + "");
        }
        public void BFS( Node root)
        {
            if(root ==null)
            {
                return;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count >0)
            {
                root = q.Dequeue();
                Console.WriteLine(root.data + "");
                if (root.left != null)
                    q.Enqueue(root.left);
                if (root.right != null)
                    q.Enqueue(root.right);
            }
        }
        public void DFS(Node root)
        {
            if(root==null)
            {
                return; 
            }
            Console.WriteLine(root.data + "");
            DFS(root.left);
            DFS(root.right);
        }
    }
}
