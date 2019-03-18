using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class ConvertSortedListtoBST
    {
        
        public int CountNodes(Node start)
        {
            int count = 0; 
            while(start !=null)
            {
                start = start.next;
                count++;
            }
            return count;
        }
    }
}
