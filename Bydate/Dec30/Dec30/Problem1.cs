using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    public class Node
    {
        public int val;
        public Node left, right;
        public Node(int x)
        {
            this.val = x;
        }
    }
    class Problem1
    {
        public string TreeToArray(Node start)
        {
            List<int> l = new List<int>();
            Queue<Node> q = new Queue<Node>();
            
            q.Enqueue(start);
            while(q.Count != 0)
            {
                Node n = q.Dequeue();
                l.Add(n.val);
                
                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }
            string s = l.ToString();
            return s;
        }
    }
}
