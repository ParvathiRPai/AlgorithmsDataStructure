using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class s10
    {
        public NodeLL Reorder(NodeLL start)
        {
            NodeLL current = start;
            NodeLL dummy = new NodeLL(0);
            Stack<NodeLL> s = new Stack<NodeLL>();
            int length = GetLength(start);
            int mid = length / 2;
            for(int i=0; i<mid;i++)
            {
                start = start.next;
            }
            for(int i=mid;i<length;i++)
            {
                s.Push(start);
                start = start.next;
            }
           while(current != null)
            {
                dummy.next = current;
                NodeLL stack = s.Pop();
                current.next = stack;
                current = current.next;
            }
            return current;
        }
        public int GetLength(NodeLL start)
        {
            int count = 0; 
            while(start!= null)
            {
                count++;
                start = start.next;
            }
            return count;
        }

    }
}
