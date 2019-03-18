using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class MergeSorted
    {
        public Node MergeList(Node []List)
        {
            Node result = null;
            for(int i=0; i<List.Length;i++)
            {
                result = Merge(List[i], result);
            }
            return result;
        }
        public Node Merge(Node start1, Node start2)
        {
            Node result = null; 
            while(start1 !=null && start2 !=null)
            {
                if (start1.data > start2.data)
                {
                    result = start2;
                    start2 = start2.next;
                }
                else
                {
                    result = start1;
                    start1 = start1.next;
                }
            }
            return result;
        }
    }
}
