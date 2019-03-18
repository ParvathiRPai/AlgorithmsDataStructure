using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class LoopDetection
    {
        public Node Loop(Node start)
        {
            Node slow = start;
            Node fast = start;
            while(fast.next !=null && fast !=null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow==fast)
                {
                    break;
                }
            }
            if(fast==null || fast.next==null)
            {
                return null;
            }
            slow = start;
            while(slow !=fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return fast;
        }
    }
}
