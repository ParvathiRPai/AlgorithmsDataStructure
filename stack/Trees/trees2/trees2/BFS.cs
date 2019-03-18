using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees2
{
    class BFS
    {
        public void BreadthFirst(Node start)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(start);
            while(q.Count > 0)
            {
                Node n = q.Dequeue();
                Console.WriteLine(n.data);
                if(n.left != null)
                {
                    q.Enqueue(n.left);
                }
                if(n.right != null)
                {
                    q.Enqueue(n.right);
                }
            }
        }

        public void DFS(Node start)
        {
            if (start == null)
                return;
            Console.WriteLine(start.data);
            DFS(start.left);
            DFS(start.right);
        }
        public bool CheckIfBalanced(Node root)
        {
          if(root == null)
            {
                return true;
            }
            int left = Height(root.left);
            int right = Height(root.right);
            int dif = Math.Abs(left - right);
            if(dif >1)
            {
                return false;
            }
            else
            {
                return CheckIfBalanced(root.left) && CheckIfBalanced(root.right);
            }
        }
        public int Height(Node root)
        {
            if (root == null)
                return -1;
            else
                return (1 + Math.Max(Height(root.left), Height(root.right)));
        }

    }
}
