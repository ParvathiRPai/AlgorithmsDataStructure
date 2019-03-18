using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class NodeLL
    {
        public int data;
        public NodeLL next;
        public NodeLL(int x)
        {
            this.data = x;
        }
    }
    class S6
    {
        public void RemoveDuplicates(NodeLL start)
        {
            HashSet<int> map = new HashSet<int>();
            NodeLL prev = null;
            while(start != null)
            {
                if(map.Contains(start.data))
                {
                    prev.next = start.next;
                    
                    start = start.next;
                }
                else
                {
                    map.Add(start.data);
                    prev = start;
                    start = start.next;
                }
            }
        }
    }
}
