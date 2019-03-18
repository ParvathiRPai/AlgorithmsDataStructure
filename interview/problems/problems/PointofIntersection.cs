using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
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
    
    class PointofIntersection
    {
        public NodeLL RemoveDifference(NodeLL start, int k)
        {
            NodeLL current = start;
            for(int i=0; i<k; i++)
            {
                current = current.next;
            }
            return current;
        }
        public NodeLL GetCommon(NodeLL current, NodeLL start)
        {
            while(current != null && start != null)
            {
               if(current.data==start.data)
                {
                    return current;
                }
               else
                {
                    current = current.next;
                    start = start.next;
                }
            }
            return null;
        }
        public void GetDifferece(NodeLL start1, NodeLL start2 )
        {
            int l1 = GetLengthofLinkedList(start1);
            int l2 = GetLengthofLinkedList(start2);
            int diff = Math.Abs(l1 - l2);
            if(l1 > l2)
            {
               NodeLL current= RemoveDifference(start1,diff);
                NodeLL common = GetCommon(current, start2);
                Console.WriteLine(common.data);
                Console.ReadKey();
            }
            else
            {
                NodeLL current=RemoveDifference(start2, diff);
                NodeLL common = GetCommon(current, start1);
                Console.WriteLine(common.data);
                Console.ReadKey();
            }
            

        }
        public int GetLengthofLinkedList(NodeLL start)
        {
            int count = 0; 
            while(start !=null)
            {
                count++;
                start = start.next;
            }
            return count;
        }
    }

    class DetectCycle
    {
        public NodeLL DetectCycleNode(NodeLL start)
        {
            NodeLL slow = start;
            NodeLL fast = start;
            while (start != null)
            {
                slow = start.next;
                fast = fast.next.next;
                if(slow==fast)
                {
                    break;
                }
            }
            slow = start;
            while(slow!=fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return fast;
        }
        public NodeLL GetMiddle(NodeLL start)
        {
            NodeLL slow = start;
            NodeLL fast = start;
            while(fast !=null && fast.next !=null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}
