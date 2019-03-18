using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class NodeLL
    {
        public int data;
        public NodeLL next;
        public NodeLL(int data)
        {
            this.data = data;
        }
    }

    class SplitLinledListParts
    {
        public int GetLength(NodeLL start)
        {
            int count = 0;
            while(start != null)
            {
                count++;
                start = start.next;
            }
            return count;
        }
        public List<List<NodeLL>> SplitLinkedList(NodeLL start, int count, int k)
        {
            int i = 0;
            List<List<NodeLL>> n1 = new List<List<NodeLL>>();
            List<NodeLL> n = new List<NodeLL>();
            int count1 = count / k;
            while (start.next != null)
            {
                while (i <= count1)
                {
                    n.Add(start);
                    i++;
                    start = start.next;
                }
                n1.Add(n);
                i = 0;
              
            }

            while(n.Count != k)
            {
                n.Add(null);
            }
            n1.Add(n);
            return n1;
        }

    }
}
