using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Problem2
    {
        public int max = Int32.MinValue; 
        public int MaxSum(Node root)
        {
            Helper(root);
            return max;
        }
        public int Helper(Node root)
        {
            if (root == null)
                return 0;
            int left = Helper(root.left);
            int right = Helper(root.right);
            int current = 0;
            current = Math.Max(current, Math.Max(left + root.data, right + root.data));
            max = Math.Max(max, left + root.data + right);
            return current;
        }
        public string Traversal(Node root)
        {
            var res = new List<string>();
            var q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Any())
            {
                int n = q.Count;
                for(int i=0; i<n;i++)
                {
                    var curr = q.Dequeue();
                    if(curr== null)
                    {
                        res.Add("n");
                    }
                    else
                    {
                        res.Add($"{curr.data}");
                    }
                    
                    if (root.left != null)
                        q.Enqueue(root.left);
                    if (root.right != null)
                        q.Enqueue(root.right);
                }
               

            }
            return string.Join(",",res);
        }
    }
}
