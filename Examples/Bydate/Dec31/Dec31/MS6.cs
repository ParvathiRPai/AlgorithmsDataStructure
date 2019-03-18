using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS6
    {
        public NodeLL MergeK(NodeLL []list)
        {
            NodeLL ptr = new NodeLL(0);
            NodeLL res = ptr;
            for(int i=0; i<list.Length;i++)
            {
                ptr = Merge(ptr,list[i]);
            }
            return ptr;
        }
        public NodeLL Merge(NodeLL ptr, NodeLL l1)
        {
            NodeLL res = new NodeLL(0);
            NodeLL head = res;
            while(ptr != null && l1 != null)
            {
                    if (ptr.data < l1.data)
                    {
                        res = new NodeLL(ptr.data);
                        ptr = ptr.next;
                    }
                    else
                    {
                        res = new NodeLL(l1.data);
                    l1 = l1.next;
                    }
                res = res.next;
                
            }
            res.next = l1 != null ? l1 : ptr;
            return head.next;
        }
    }
}
