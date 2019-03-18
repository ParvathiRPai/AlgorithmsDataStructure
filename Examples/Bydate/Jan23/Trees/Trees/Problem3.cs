using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Problem3
    {
        public Node Deserialize(string s)
        {
            var nodes = s.Split(',');
            int i = 0;
            Node root = new Node(int.Parse(nodes[0]));
            i++;
            var q = new Queue<Node>();
            q.Enqueue(root);
            while(i<nodes.Length)
            {
                var current = q.Dequeue();
                if(nodes[i]!="n")
                {
                    current.left = new Node(int.Parse(nodes[i]));
                        q.Enqueue(current.left);
                }
                i++;
                if(nodes[i] != "n")
                {
                    current.right = new Node(int.Parse(nodes[i]));
                    q.Enqueue(current.right);

                }
                i++;

            }
            return root;
        }
    }
}
