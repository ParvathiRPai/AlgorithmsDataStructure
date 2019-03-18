using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesringKthNodeofLinkedList
{
    class InsertNodeInLinkedList
    {
        public void InsertNode(Node start, Node Insert)
        {
            Node current = start;
            while(current.next !=null)
            {
               
                 if(Insert.data<current.next.data)
                {
                    var next = current.next;
                    Node m= new Node(Insert.data);
                    Insert = current;
                    Insert.data = m.data;
                    Insert.next=next;
                    break;
                }
                current = current.next;
            }
        }
    }
}
