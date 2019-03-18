using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class RemoveDuplicates
    {
        public void Remove(Node start)
        {
            HashSet<int> map = new HashSet<int>();
            Node current = start;
            Node Prev = null;
            while(current !=null)
            {
                if(map.Contains(current.data))
                {
                    Prev.next = current.next;
                }
                else
                {
                    map.Add(current.data);
                    Prev = current;
                }
                current = current.next;
            }
            
        }

        public void WithoutMap(Node start)
        {
            Node current = start;
           
            while(current !=null)
            {
                Node runner = current;
                
                    while(runner.next !=null)
                    {
                        if(current.data==runner.next.data)
                        {
                            runner.next = runner.next.next;
                        }
                        else
                        {
                            runner = runner.next;
                        }
                        
                    }
                current = current.next;
            }

            

        }
        public Node ReturnKthElement(Node start, int k)
        {
            Node slow = start;
            Node fast = start;

            for(int i=0; i<k; i++)
            {
                fast = fast.next;
            }

            while( fast.next !=null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow; 
        }
        
        public int LengthOfLinkedList(Node start)
        {
            Node current = start;
            int count = 0; 
            while(current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }

        public void DeleteMiddle(Node start)
        {
            
           int count= LengthOfLinkedList(start);
            Node current = start;
          
           
            int middle = (int) count / 2;
            for(int i=0; i<count;i++)
            {
                if (i == middle-1)
                {
                    current.data = current.next.data;
                    current.next = current.next.next;
                    
                }
                else
                {
                    current = current.next;

                }
                
            }
            
        }
    }
}
