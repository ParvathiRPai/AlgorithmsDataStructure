using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLinkedList
{
    class RemoveDuplicates
    {
        public Node Duplicates(Node start)
        {
            HashSet<int> set = new HashSet<int>();
            Node current = start;
            Node prev = null;
          
            while(current != null)
            {
                if(set.Contains(current.data))
                {
                    prev.next = current.next;
                    
                }
                else
                {
                    set.Add(current.data);
                    prev = current;
                   
                }
                current = current.next;
            }
         
            return start;
        }
        public void Dispaly(Node start)
        {
            while(start!=null)
            {
                Console.WriteLine("->" + start.data);
                start = start.next;
            }
        }
    }
}
