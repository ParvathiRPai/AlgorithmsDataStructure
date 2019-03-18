using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class MS5
    {
        public List<List<int>> LevelOrderTraversal(Node root)
        {
            List<List<int>> l = new List<List<int>>();
            if(root==null)
            {
                return l;
            }
            Queue<int> q = new Queue<int>();
            q.Enqueue(root.data);
            while(q.Count != 0)
            {
                var size = q.Count;
                var res = new List<int>();
                for(int i=0; i<size;i++)
                {
                    res.Add(q.Dequeue());
                    if (root.left != null)
                        q.Enqueue(root.left.data);
                    if (root.right != null)
                        q.Enqueue(root.right.data);

                }
                l.Add(res);
            }
            return l;
                

          
        }
    }
}
