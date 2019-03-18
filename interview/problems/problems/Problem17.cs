using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem17
    {
        public void BFS(Node start)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(start);
            while(q.Count !=0)
            {
                 start= q.Dequeue();
                Console.WriteLine(start.data);
                if(start.left != null)
                    q.Enqueue(start.left);
                
                if(start.right !=null)
                    q.Enqueue(start.right);
                
            }
        }
    }
}
