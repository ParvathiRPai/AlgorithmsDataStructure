using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{

    class FindIntersectionpont
    {
       private Node head1;
       private Node head2;

      public int GetLengths(Node start)
        {
            int count = 0;
            Node current = start;
            while(current!=null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
        public int getNode()
        {
            int d;
            int c1 = GetLengths(head1);
            int c2 = GetLengths(head2);
            if(c1 > c2)
            {
                d = c1 - c2;
                return GetIntersection(d, head1, head2);
            }
            else
            {
                d = c2 - c1;
                return GetIntersection(d, head1, head2);
            }
        }
        public int GetIntersection(int d, Node node1, Node node2)
        {
            Node current1 = node1;
            Node current2 = node2;
            for(int i=0; i< d; i++)
            {
                current1 = current1.next;
            }
            while(current1 !=null && current2 != null)
            {
                if(current1.data==current2.data)
                {
                    return current1.data;
                }
                current1 = current1.next;
                current2 = current2.next;
            }
            return 0;
        }

    }
}
