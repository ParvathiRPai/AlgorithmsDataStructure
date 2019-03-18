using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int x)
        {
            this.data = x;
        }
    }
    class Problem1
    {
        public List<List<int>> ZigZag(Node root)
        {
            var res = new List<List<int>>();
            var q = new Queue<Node>();
            q.Enqueue(root);
            Node separator = new Node(-1);
            q.Enqueue(separator);
            var l = new List<int>();
            bool l2r = true;
            while(q.Count > 0)
            {
                Node current = q.Dequeue();
                if(current == separator)
                {
                    if(q.Count >0)
                    {
                        q.Enqueue(separator);
                    }
                    if(l2r==false)
                    {
                        l.Reverse();
                    }
                    res.Add(l);
                    l = new List<int>();
                    l2r = !l2r;
                    continue;

                }
                l.Add(current.data);
                if(current.left != null)
                {
                    q.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    q.Enqueue(current.right);
                }

            }

            return res;
        }
    }
}
