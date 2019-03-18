using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class RotateList
    {
        public Node RotateLL(Node start, int k)
        {
            Node current = start;
            Node result = null;
            Node result1 = null;
            Node rotatePoint = TraverseToPosition(current, k);
            result = rotatePoint.next;
            while (current != null)
            {
                if (current.data != rotatePoint.data)
                {
                    result.next = current;
                    current = current.next;
                    result = result.next;
                }
            }
            result = result.next;
          
            return result;
        }
        public Node TraverseToPosition(Node start, int k)
        {
            
            Node slow = start;
            Node fast = start; 
            for(int i=0; i<k; i++)
            {
                fast = fast.next;
            }
            while(fast !=null && fast.next !=null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}
