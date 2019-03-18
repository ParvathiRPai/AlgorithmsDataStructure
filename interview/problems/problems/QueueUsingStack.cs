using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class QueueUsingStack
    {
        public void Queueusingstack(NodeLL start)
        {
            Stack<NodeLL> s1 = new Stack<NodeLL>();
            Stack<NodeLL> s2 = new Stack<NodeLL>();
            while(start != null)
            {
                s1.Push(start);
                start = start.next;
            }
            while(s1.Count!=0)
            {
                NodeLL i = s1.Pop();
                s2.Push(i);
            }
            while(s2.Count !=0)
            {
                NodeLL j = s2.Pop();
                Console.WriteLine(j.data);
                
            }
        }
            
    }
}
