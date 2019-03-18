using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MS6
    {
        public List<List<int>> PrintLinear(Node root)
        {
            List<List<int>> res = new List<List<int>>();
            if(root==null)
            {
                return res;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count != 0)
            {
                int size = q.Count;
                var lis = new List<int>();
                for(int i=0; i<size;i++)
                {
                    var n = q.Dequeue();
                    lis.Add(n.data);
                    if (root.left != null) q.Enqueue(root.left);
                    if (root.right != null) q.Enqueue(root.right);
                }
                res.Add(lis);
            }
            return res;
        }

        public Node Deserialize(string data)
        {
            if(data==string.Empty)
            {
                return null;
            }
            var node = data.Split(',');
            Node root = new Node(int.Parse(node[0]));
            int i = 1;
            var q = new Queue<Node>();
            while(i < node.Length)
            {
                var curr = q.Dequeue();
                if(node[i]!= null)
                {
                    curr.left = new Node(int.Parse(node[i]));
                    q.Enqueue(curr.left);
                }
                i++;

                if (node[i] != "n")
                {
                    curr.right = new Node(int.Parse(node[i]));
                    q.Enqueue(curr.right);
                }

                i++;
            }
            return root;
        }
    }
}
